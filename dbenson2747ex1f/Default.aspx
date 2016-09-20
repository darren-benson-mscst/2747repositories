<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="dbenson2747ex1f._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>ASP.NET</h3>
        <p class="lead">dbensonCOMC2747 Exercise 1F</p>
        
    </div>

    <div class="row">
        <div class="form-horizontal">
          <div class="col-md-8">
            <div class ="form-group">
                <asp:Label ID="Label1" runat="server" Text="Vendor" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                     <asp:DropDownList ID="vendorsDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="vendorsDropDownList_SelectedIndexChanged1" CssClass="form-control"></asp:DropDownList>
                </div>
              </div>
              <div class ="form-group">
                <asp:Label ID="Label2" runat="server" Text="Purchase Order ID" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                     <asp:DropDownList ID="purchaseOrderIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="purchaseOrderIDDropDownList_SelectedIndexChanged" CssClass="form-control"></asp:DropDownList>
                </div>
              </div>
               <div class ="form-group">
                <asp:Label ID="Label3" runat="server" Text="Revision Number:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                     <asp:TextBox ID="revisionNumberTextBox" runat="server"></asp:TextBox>
                </div>
               </div>
              <div class ="form-group">
                <asp:Label ID="Label4" runat="server" Text="Status:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                   <asp:TextBox ID="statusTextBox" runat="server"></asp:TextBox>
                </div>
               </div>
              <%--<div class ="form-group">
                <asp:Label ID="Label5" runat="server" Text="Employee ID:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                   <asp:TextBox ID="employeeIDTextBox" runat="server"></asp:TextBox>
                </div>
               </div>--%>
              <div class ="form-group">
                <asp:Label ID="Label6" runat="server" Text="Employee:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                   <asp:DropDownList ID="employeeNameDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
               </div>
              <%--<div class ="form-group">
                <asp:Label ID="Label6" runat="server" Text="Ship Method ID:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                   <asp:TextBox ID="shipMethodIDTextBox" runat="server"></asp:TextBox>
                </div>
               </div>--%>
              <div class ="form-group">
                <asp:Label ID="Label12" runat="server" Text="Ship Method:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                   <asp:DropDownList ID="shipMethodDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
               </div>
              <div class ="form-group">
                <asp:Label ID="Label7" runat="server" Text="Ship Date:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                   <asp:TextBox ID="shipDateTextBox" runat="server"></asp:TextBox>
                </div>
               </div>
              <div class ="form-group">
                <asp:Label ID="Label5" runat="server" Text="Order Details:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                     <asp:GridView ID="purchaseOrderDetailsGridView" runat="server" AutoGenerateColumns="False" CssClass="table-bordered table-hover">
                         <Columns>
                             <asp:BoundField DataField="PurchaseOrderID" HeaderText="PurchaseOrderID" Visible="False" />
                             <asp:BoundField DataField="PurchaseOrderDetailID" HeaderText="DetID">
                             <HeaderStyle Width="4em" />
                             </asp:BoundField>
                             <asp:BoundField DataField="DueDate" DataFormatString="{0:MM/dd/yyyy}" HeaderText="Due Date">
                             <HeaderStyle Width="8em" />
                             </asp:BoundField>
                             <asp:BoundField DataField="OrderQty" DataFormatString="{0:N0}" HeaderText="Qty">
                             <HeaderStyle Width="3em" />
                             </asp:BoundField>
                             <asp:BoundField DataField="ProductID" HeaderText="ProdID">
                             <HeaderStyle Width="4em" />
                             </asp:BoundField>
                             <asp:BoundField DataField="UnitPrice" DataFormatString="{0:C2}" HeaderText="Unit Price">
                             <HeaderStyle Width="8em" />
                             </asp:BoundField>
                             <asp:BoundField DataField="LineTotal" DataFormatString="{0:C2}" HeaderText="Line Total">
                             <HeaderStyle Width="8em" />
                             </asp:BoundField>
                             <asp:BoundField DataField="ReceivedQty" DataFormatString="{0:N0}" HeaderText="Rec">
                             <HeaderStyle Width="3em" />
                             </asp:BoundField>
                             <asp:BoundField DataField="RejectedQty" DataFormatString="{0:N0}" HeaderText="Rej">
                             <HeaderStyle Width="3em" />
                             </asp:BoundField>
                             <asp:BoundField DataField="StockedQty" DataFormatString="{0:N0}" HeaderText="Stocked">
                             <HeaderStyle Width="3em" />
                             </asp:BoundField>
                         </Columns>
                     </asp:GridView>
                </div>
               </div>
              <div class ="form-group">
                <asp:Label ID="Label8" runat="server" Text="Subtotal:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                   <asp:Label ID="subtotalLabel" runat="server" ></asp:Label>
                </div>
               </div>
              <div class ="form-group">
                <asp:Label ID="Label9" runat="server" Text="Tax:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                   <asp:Label ID="taxAmtLabel" runat="server"></asp:Label>
                </div>
               </div>
              <div class ="form-group">
                <asp:Label ID="Label10" runat="server" Text="Freight:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                   <asp:TextBox ID="freightTextBox" runat="server"></asp:TextBox>
                </div>
               </div>
              <div class ="form-group">
                <asp:Label ID="Label11" runat="server" Text="Total Due:" CssClass="control-label col-sm-3"></asp:Label>
                 <div class ="col-sm-9">
                   <asp:Label ID="totalDueLabel" runat="server"></asp:Label>
                </div>
               </div>
              
           </div>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        
    </div>

</asp:Content>
