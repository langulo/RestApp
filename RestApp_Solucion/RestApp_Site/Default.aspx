<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RestApp_Site._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="pnlIngresar" runat="server">
        <header>
            <h4>Registro de cuenta</h4>
        </header>
        <h2>Mesa #15</h2>

        <div class="form-group row">
            <label for="<%:txbContrsena.ID  %>" class="col-sm-2 col-form-label">Contraseña</label>
            <div class="col-sm-3">
                <asp:TextBox ID="txbContrsena" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
            <div class="col-sm-2">
                <asp:Button ID="btnIngresar" runat="server" Text="Ver cuenta" CssClass="btn btn-info " OnClick="btnIngresar_Click" />

            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="pnlCuenta" runat="server" Visible="false">
        <header>
            <h4>Registro de cuenta</h4>
        </header>
        <h2>Mesa #15</h2>

        <div class="form-group row">
            <label for="<%:lblTotal.ID  %>"" class="col-sm-2 col-form-label">Total</label>
            <div class="col-sm-3">
                <asp:Label ID="lblTotal" runat="server" class="label label-default" Text="83,000.0"></asp:Label>

            </div>
            <div class="col-sm-2">
                <asp:Button ID="btnLlamarMesero" runat="server" Text="Llamar a mesero" CssClass="btn btn-info " />

            </div>
        </div>
         <div class="form-group row">
            <label   class="col-sm-8 col-form-label"> </label>
            
            <div class="col-sm-2">
                <asp:Button ID="btnAgregarProducto" runat="server" Text="Agregar Producto" CssClass="btn btn-primary " /> 

            </div>
        </div>

        
        <% if (gvListado.Rows.Count == 0)
            {%><a class="btn btn-danger btn-lg">No hay productos</a>
        <% }%>
        <div class="table-responsive">

            <asp:GridView ID="gvListado" CssClass="table table-hover " runat="server" AutoGenerateColumns="False" AllowPaging="false" OnSelectedIndexChanging="gvListado_SelectedIndexChanging" OnPageIndexChanging="gvListado_PageIndexChanging" PageSize="20" OnRowDataBound="gvListado_RowDataBound">
               
                <Columns>
                   <%-- <asp:CommandField ControlStyle-CssClass="btn btn-primary colorLetraBlanco" SelectText="Ver" ShowSelectButton="True">
                    <ControlStyle CssClass="btn btn-primary colorLetraBlanco" />
                    </asp:CommandField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HiddenField ID="IdHF" runat="server" Value='<%# Eval("Entrada_id")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                    <asp:BoundField DataField="Cantidad" DataFormatString="{0:C0}" HeaderText="Cant" />
                    <asp:BoundField DataField="Producto" HeaderText="Producto" /> 
                    <asp:BoundField DataField="Total"   HeaderText="Total" />
                </Columns>
                  <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                        <HeaderStyle BackColor="#666666" Font-Bold="True" ForeColor="white" />
                        <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
                        <RowStyle BackColor="#CCCCCC" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                 <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
        </div>


         <div class="form-group row">
            <label   class="col-sm-8 col-form-label"> </label>
            
            <div class="col-sm-4">
                <asp:Button ID="btnDividir" runat="server" Text="Dividir la cuenta" CssClass="btn btn-warning " /> 

            </div>
        </div>
    </asp:Panel>



</asp:Content>
