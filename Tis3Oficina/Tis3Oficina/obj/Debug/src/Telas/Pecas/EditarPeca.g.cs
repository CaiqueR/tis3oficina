﻿#pragma checksum "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "543A9F3C553958A299091892E94C4DDE40F44B18D9DDC61F6D4015A9743ED49B"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tis3Oficina.src.Telas.Pecas;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Tis3Oficina.src.Telas.Pecas {
    
    
    /// <summary>
    /// EditarPeca
    /// </summary>
    public partial class EditarPeca : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridNomePec;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textNomePec;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridEmail;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textQtdePec;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.MaskedTextBox textValorPec;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tis3Oficina;component/src/telas/pecas/editarpeca.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.gridNomePec = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.textNomePec = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml"
            this.textNomePec.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.validateNome);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gridEmail = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.textQtdePec = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml"
            this.textQtdePec.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.validateNumber);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textValorPec = ((Xceed.Wpf.Toolkit.MaskedTextBox)(target));
            return;
            case 6:
            
            #line 46 "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnVoltar);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 57 "..\..\..\..\..\src\Telas\Pecas\EditarPeca.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSalvar);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

