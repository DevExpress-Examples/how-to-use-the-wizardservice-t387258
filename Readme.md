<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/VM-DrivenWizard/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/VM-DrivenWizard/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/VM-DrivenWizard/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/VM-DrivenWizard/MainWindow.xaml.vb))
* [Model.cs](./CS/VM-DrivenWizard/Model/Model.cs) (VB: [Model.vb](./VB/VM-DrivenWizard/Model/Model.vb))
* [CongratulationsPageViewModel.cs](./CS/VM-DrivenWizard/ViewModels/CongratulationsPageViewModel.cs) (VB: [CongratulationsPageViewModel.vb](./VB/VM-DrivenWizard/ViewModels/CongratulationsPageViewModel.vb))
* [MainWindowViewModel.cs](./CS/VM-DrivenWizard/ViewModels/MainWindowViewModel.cs) (VB: [MainWindowViewModel.vb](./VB/VM-DrivenWizard/ViewModels/MainWindowViewModel.vb))
* [PlayTunePageViewModel.cs](./CS/VM-DrivenWizard/ViewModels/PlayTunePageViewModel.cs) (VB: [PlayTunePageViewModel.vb](./VB/VM-DrivenWizard/ViewModels/PlayTunePageViewModel.vb))
* [WelcomePageViewModel.cs](./CS/VM-DrivenWizard/ViewModels/WelcomePageViewModel.cs) (VB: [WelcomePageViewModel.vb](./VB/VM-DrivenWizard/ViewModels/WelcomePageViewModel.vb))
* [WizardViewModelBase.cs](./CS/VM-DrivenWizard/ViewModels/WizardViewModelBase.cs) (VB: [WizardViewModelBase.vb](./VB/VM-DrivenWizard/ViewModels/WizardViewModelBase.vb))
* [CongratulationsPage.xaml](./CS/VM-DrivenWizard/Views/CongratulationsPage.xaml) (VB: [CongratulationsPage.xaml](./VB/VM-DrivenWizard/Views/CongratulationsPage.xaml))
* [PlayTunePage.xaml](./CS/VM-DrivenWizard/Views/PlayTunePage.xaml) (VB: [PlayTunePage.xaml](./VB/VM-DrivenWizard/Views/PlayTunePage.xaml))
* [WelcomePage.xaml](./CS/VM-DrivenWizard/Views/WelcomePage.xaml) (VB: [WelcomePage.xaml](./VB/VM-DrivenWizard/Views/WelcomePage.xaml))
<!-- default file list end -->
# How to: Use the WizardService


This example demonstrates how to use the <a href="https://documentation.devexpress.com/#WPF/CustomDocument116321">WizardService</a>. See Implementation Details for more information.<br><br>See also:<br><a href="https://www.devexpress.com/Support/Center/p/T415416">How to create a Wizard with pages defined in XAML</a><br><a href="https://www.devexpress.com/Support/Center/p/T415475">How to: Create a wizard based on a collection of view models</a>


<h3>Description</h3>

<p>Based on&nbsp;the template defined within PageGeneratorTemplate, WizardService generates WizardPage for every View in compliance&nbsp;with MVVM. It allows implementing navigation between pages at the level of a page's ViewModel.&nbsp;In this example, the Allow_ and Show_ (Next, Back, Cancel, Finish) &nbsp;properties of WizardPage are bound to a page's ViewModel properties, and are used to hide/disable specific navigation buttons based on a custom logic.<br><br>The Show_ and Allow_ properties are defined in both WizardPage and Wizard.<br><strong>The Wizard's properties have a higher priority than a corresponding WizardPage's properties.</strong><br><br>In addition, ViewModels in the project&nbsp;implement <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressMvvmISupportWizardNextCommandtopic">ISupportWizard_Command</a>&nbsp;interfaces&nbsp;that expose the Can_ and On_ methods. By invoking the Can_ method, the Wizard determines whether a corresponding navigation button is enabled. When a user presses that button, the On_ method is invoked, and the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfControlsWizardService_Navigatetopic.aspx">WizardService.Navigate</a>&nbsp;method switches the Wizard to another page.<br><strong>The value returned by the Can_ method has a higher priority than the WizardPage's Allow_ property value.</strong></p>
<br><br>

<br/>


