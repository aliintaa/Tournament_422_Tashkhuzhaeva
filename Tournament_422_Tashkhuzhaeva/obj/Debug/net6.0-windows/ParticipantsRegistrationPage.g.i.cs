﻿#pragma checksum "..\..\..\ParticipantsRegistrationPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57C1FEAD13A1D715FCFBB1AFC0CE4D2853AADBEC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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
using Tournament_422_Tashkhuzhaeva;


namespace Tournament_422_Tashkhuzhaeva {
    
    
    /// <summary>
    /// ParticipantsRegistrationPage
    /// </summary>
    public partial class ParticipantsRegistrationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\ParticipantsRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Container;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\ParticipantsRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTBx;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\ParticipantsRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTBx;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ParticipantsRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox RePasswordTBx;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ParticipantsRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegistrationBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ParticipantsRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginBtn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\ParticipantsRegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ErrorTBk;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tournament_422_Tashkhuzhaeva;V1.0.0.0;component/participantsregistrationpage.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\ParticipantsRegistrationPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Container = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.LoginTBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PasswordTBx = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.RePasswordTBx = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.RegistrationBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\ParticipantsRegistrationPage.xaml"
            this.RegistrationBtn.Click += new System.Windows.RoutedEventHandler(this.RegistrationBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LoginBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\ParticipantsRegistrationPage.xaml"
            this.LoginBtn.Click += new System.Windows.RoutedEventHandler(this.LoginBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ErrorTBk = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

