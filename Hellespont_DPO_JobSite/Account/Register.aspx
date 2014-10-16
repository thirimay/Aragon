<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Hellespont_DPO_JobSite.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to create a new account.</h2>
    </hgroup>

    <asp:CreateUserWizard runat="server" ID="RegisterUser" ViewStateMode="Disabled" OnCreatedUser="RegisterUser_CreatedUser">
        <LayoutTemplate>
            <asp:PlaceHolder runat="server" ID="wizardStepPlaceholder" />
            <asp:PlaceHolder runat="server" ID="navigationPlaceholder" />
        </LayoutTemplate>
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server" ID="RegisterUserWizardStep">
                <ContentTemplate>
                    <p class="message-info">
                        Passwords are required to be a minimum of <%: Membership.MinRequiredPasswordLength %> characters in length.
                    </p>

                    <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>

                    <fieldset>
                        <legend>Registration Form</legend>
                        <ol>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="UserName">User name</asp:Label>
                                <asp:TextBox runat="server" ID="UserName" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                    CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Email">Email address</asp:Label>
                                <asp:TextBox runat="server" ID="Email" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                    CssClass="field-validation-error" ErrorMessage="The email address field is required." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                    CssClass="field-validation-error" ErrorMessage="The password field is required." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirm password</asp:Label>
                                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                            </li>
                        </ol>
                        <asp:Button runat="server" CommandName="MoveNext" Text="Register" />
                    </fieldset>
                </ContentTemplate>
                <CustomNavigationTemplate />
            </asp:CreateUserWizardStep>
            <asp:WizardStep ID="RegisterUserWizardStep2" runat="server">
                <div>
                    <ol>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Nationality">Nationality</asp:Label>
                            <asp:DropDownList ID="Nationality" runat="server" >                                
                            </asp:DropDownList>
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Gender">Gender</asp:Label>
                               <asp:RadioButtonList runat="server" ID="Gender">
                                   <asp:ListItem Text="Male" Value="0"></asp:ListItem>
                                   <asp:ListItem Text="Female" Value="1"></asp:ListItem>
                               </asp:RadioButtonList>
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="DOB">Date of Birth</asp:Label>
                            <asp:TextBox ID="DOB" runat="server" ></asp:TextBox>                            
                        </li>
                         <li>
                            <asp:Label runat="server" AssociatedControlID="Race">Race</asp:Label>
                            <asp:DropDownList ID="Race" runat="server" >                                
                            </asp:DropDownList>
                        </li>
                          <li>
                            <asp:Label runat="server" AssociatedControlID="Religion">Religion</asp:Label>
                            <asp:DropDownList ID="Religion" runat="server" >                                
                            </asp:DropDownList>
                        </li>
                    </ol>
                </div>                
            </asp:WizardStep>
            <asp:WizardStep ID="RegisterUserWizardStep3" runat="server">
                <div>
                    <ol>
                     <li>
                            <asp:Label runat="server" AssociatedControlID="Location">Location</asp:Label>
                               <asp:RadioButtonList runat="server" ID="Location">
                                   <asp:ListItem Text="Male" Value="0"></asp:ListItem>
                                   <asp:ListItem Text="Female" Value="1"></asp:ListItem>
                               </asp:RadioButtonList>
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Address1">Address Line 1</asp:Label>
                            <asp:TextBox ID="Address1" runat="server" ></asp:TextBox>                            
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Address2">Address Line 2</asp:Label>
                            <asp:TextBox ID="Address2" runat="server" ></asp:TextBox>                            
                        </li>
                         <li>
                            <asp:Label runat="server" AssociatedControlID="ContactNo">Contact Number</asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>                            
                        </li>
                     </ol>
                </div>
            </asp:WizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>
</asp:Content>