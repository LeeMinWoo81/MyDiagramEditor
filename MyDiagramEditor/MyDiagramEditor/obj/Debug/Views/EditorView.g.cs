﻿#pragma checksum "..\..\..\Views\EditorView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "38CC8D4D18EB9CB702DA65065B3392882D1D39158232E5514FAA3A34336F3EA8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Caliburn.Micro;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MyDiagramEditor.Converters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace MyDiagramEditor.Views {
    
    
    /// <summary>
    /// EditorView
    /// </summary>
    public partial class EditorView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Push;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pop;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Clean;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button lasso;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearSelection;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RotateRight;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RotateLeft;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Duplicate;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cut;
        
        #line default
        #line hidden
        
        
        #line 275 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ColorConnexion;
        
        #line default
        #line hidden
        
        
        #line 286 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConnexionThickness;
        
        #line default
        #line hidden
        
        
        #line 289 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpThickness;
        
        #line default
        #line hidden
        
        
        #line 294 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownThickness;
        
        #line default
        #line hidden
        
        
        #line 301 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyThickness;
        
        #line default
        #line hidden
        
        
        #line 369 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ColorBorderShape;
        
        #line default
        #line hidden
        
        
        #line 380 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Fill;
        
        #line default
        #line hidden
        
        
        #line 393 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Line;
        
        #line default
        #line hidden
        
        
        #line 405 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Square;
        
        #line default
        #line hidden
        
        
        #line 416 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dashed;
        
        #line default
        #line hidden
        
        
        #line 431 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker colorSelector;
        
        #line default
        #line hidden
        
        
        #line 455 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CanvasName;
        
        #line default
        #line hidden
        
        
        #line 456 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CanvasWidth;
        
        #line default
        #line hidden
        
        
        #line 458 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CanvasHeight;
        
        #line default
        #line hidden
        
        
        #line 460 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPosition;
        
        #line default
        #line hidden
        
        
        #line 472 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb horizontal;
        
        #line default
        #line hidden
        
        
        #line 481 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb diagonal;
        
        #line default
        #line hidden
        
        
        #line 489 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb vertical;
        
        #line default
        #line hidden
        
        
        #line 499 "..\..\..\Views\EditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl Items;
        
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
            System.Uri resourceLocater = new System.Uri("/MyDiagramEditor;component/views/editorview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\EditorView.xaml"
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
            
            #line 30 "..\..\..\Views\EditorView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Export);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Push = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.Pop = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Clean = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.lasso = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.ClearSelection = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.RotateRight = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.RotateLeft = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.Duplicate = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.Cut = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.ColorConnexion = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.ConnexionThickness = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.UpThickness = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.DownThickness = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.ApplyThickness = ((System.Windows.Controls.Button)(target));
            return;
            case 16:
            this.ColorBorderShape = ((System.Windows.Controls.Button)(target));
            return;
            case 17:
            this.Fill = ((System.Windows.Controls.Button)(target));
            return;
            case 18:
            this.Line = ((System.Windows.Controls.Button)(target));
            return;
            case 19:
            this.Square = ((System.Windows.Controls.Button)(target));
            return;
            case 20:
            this.Dashed = ((System.Windows.Controls.Button)(target));
            return;
            case 21:
            this.colorSelector = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            return;
            case 22:
            this.CanvasName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 23:
            this.CanvasWidth = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 24:
            this.CanvasHeight = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 25:
            this.TextBlockPosition = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 26:
            this.horizontal = ((System.Windows.Controls.Primitives.Thumb)(target));
            return;
            case 27:
            this.diagonal = ((System.Windows.Controls.Primitives.Thumb)(target));
            return;
            case 28:
            this.vertical = ((System.Windows.Controls.Primitives.Thumb)(target));
            return;
            case 29:
            this.Items = ((System.Windows.Controls.ItemsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

