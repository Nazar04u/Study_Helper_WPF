﻿#pragma checksum "..\..\..\..\Views\NoteWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BD09A331BB2221A7486324721311D63B63F2DA17"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace StudyHelperApp.Views {
    
    
    /// <summary>
    /// NoteWindow
    /// </summary>
    public partial class NoteWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\Views\NoteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView NotesListView;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\NoteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NoteTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StudyHelperApp;V1.0.0.0;component/views/notewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\NoteWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 21 "..\..\..\..\Views\NoteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HomeButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\..\..\Views\NoteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToDoButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 23 "..\..\..\..\Views\NoteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GradesButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 24 "..\..\..\..\Views\NoteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 25 "..\..\..\..\Views\NoteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NotesListView = ((System.Windows.Controls.ListView)(target));
            
            #line 47 "..\..\..\..\Views\NoteWindow.xaml"
            this.NotesListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.NotesListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NoteTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 78 "..\..\..\..\Views\NoteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveNoteButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 86 "..\..\..\..\Views\NoteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteNoteButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

