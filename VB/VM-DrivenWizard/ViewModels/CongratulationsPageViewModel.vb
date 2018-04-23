﻿Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace VM_DrivenWizard.ViewModels
    Public Class CongratulationsPageViewModel
        Inherits WizardViewModelBase
        Implements ISupportWizardFinishCommand

        Protected Sub New()
        End Sub

        Public ReadOnly Property CanFinish() As Boolean Implements ISupportWizardFinishCommand.CanFinish
            Get
                Return True
            End Get
        End Property

        Public Sub OnFinish(ByVal e As CancelEventArgs) Implements ISupportWizardFinishCommand.OnFinish
            Me.GetService(Of IMessageBoxService)().ShowMessage("Thank you for completing this WPF feature tour!", "WPF Tour", MessageButton.OK, MessageIcon.Exclamation)
        End Sub
        Protected Overrides Function GetCanCancel() As Boolean
            Return False
        End Function
    End Class
End Namespace
