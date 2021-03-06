﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tis3Oficina.src.Config;
using Tis3Oficina.src.DAO;
using Tis3Oficina.src.OBJETOS;

namespace Tis3Oficina.src.Telas.Pecas
{
    /// <summary>
    /// Lógica interna para EditarPeca.xaml
    /// </summary>
    public partial class EditarPeca : Window
    {
        private string codPec;
        public EditarPeca(string codPec)
        {
            this.codPec = codPec;
            InitializeComponent();
            exibeDados();
        }

        private void exibeDados()
        {
            Conexao conexao = new Conexao();
            DataTable dt = new DataTable();
            try
            {
                // Query mysql
                String sql = "SELECT * FROM pecas";
                MySqlCommand cmd = new MySqlCommand(sql, conexao.getInstancia());
                bool achou = false;
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read() && !achou)
                    {
                        if (codPec == dr["CodPec"].ToString())
                        {
                            achou = true;
                            textNomePec.Text = (String)dr["NomePec"];
                            textQtdePec.Text = dr["QtdePec"].ToString();
                            textValorPec.Text = dr["ValPec"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro buscar todos Clientes : " + ex.Message, "Erro");
            }
        }

        private void btnSalvar(object sender, RoutedEventArgs e)
        {
            Peca novaPeca = new Peca();
            string nome = textNomePec.Text.Trim();
            int quantidade = int.Parse(textQtdePec.Text);

            double valor = double.Parse(textValorPec.Text.Replace("$", "").Replace(",", ""), CultureInfo.InvariantCulture);

            if (isName(nome) && isValue(textValorPec.Text))
            {
                novaPeca.NomePec = nome;
                novaPeca.QtdePeca = quantidade;
                novaPeca.ValPec = valor;

                DAOPeca peca = new DAOPeca();
                peca.editar(novaPeca, codPec);
                var alerta = new Alerta();
                alerta.conteudo.Content = "Peça editada com sucesso";
                alerta.ShowDialog();
                var telaListarPeca = new ListarPecas();
                this.Close();
                telaListarPeca.Show();
            }
            else
            {
                if (!isName(nome))
                    lblNomeIncorreto.Visibility = Visibility.Visible;
                if (!isValue(textValorPec.Text))
                    lblValorIncorreto.Visibility = Visibility.Visible;

                var alerta = new Alerta();
                alerta.conteudo.Content = "Preencha os campos corretamente!";
                alerta.ShowDialog();
            }

        }

        //Validando entrada de nome para somente caracteres
        private void validateNome(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^a-zA-Z]+").IsMatch(e.Text);
        }

        //Verificar se esta digitando numero ao invés de letra
        private void validateNumber(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-999]+").IsMatch(e.Text);


        }

        private void btnVoltar(object sender, RoutedEventArgs e)
        {
            var telaListarPeca = new ListarPecas();
            this.Close();
            telaListarPeca.Show();
        }

        //Mostra messagem de erro para usuario caso nome esteja incorreto
        private void validaNome(object sender, RoutedEventArgs e)
        {
            bool result = isName(textNomePec.Text);

            if (!result)
                lblNomeIncorreto.Visibility = Visibility.Visible;

            else
                lblNomeIncorreto.Visibility = Visibility.Hidden;
        }

        private void validaValor(object sender, RoutedEventArgs e)
        {
            bool result = isValue(textValorPec.Text);

            if (!result)
                lblValorIncorreto.Visibility = Visibility.Visible;
            else
                lblValorIncorreto.Visibility = Visibility.Hidden;
        }


        public static bool isValue(string valor)
        {
            if (valor == "$0.00")
                return false;

            return true;
        }

        public static bool isName(string name)
        {
            Regex regex = new Regex(
              "^(\\b[A-Za-z]*\\b\\s+\\b[A-Za-z]*\\b+\\.[A-Za-z])$",
            RegexOptions.IgnoreCase
            | RegexOptions.CultureInvariant
            | RegexOptions.IgnorePatternWhitespace
            | RegexOptions.Compiled
            );
            name = name.Trim();
            if (name.Length < 3 || name == "" || regex.IsMatch(name))
                return false;

            return true;
        }


    }
}
