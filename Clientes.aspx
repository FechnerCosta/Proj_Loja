<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Clientes.aspx.cs" Inherits="Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    Cadastro de Clientes</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="codigo" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." Height="306px" Width="487px">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True"></asp:CommandField>
            <asp:BoundField DataField="codigo" HeaderText="codigo" ReadOnly="True" SortExpression="codigo"></asp:BoundField>
            <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome"></asp:BoundField>
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email"></asp:BoundField>
            <asp:BoundField DataField="telefone" HeaderText="telefone" SortExpression="telefone"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LojaConnectionString2 %>" DeleteCommand="DELETE FROM [Clientes] WHERE [codigo] = @codigo" InsertCommand="INSERT INTO [Clientes] ([nome], [email], [telefone]) VALUES (@nome, @email, @telefone)" ProviderName="<%$ ConnectionStrings:LojaConnectionString2.ProviderName %>" SelectCommand="SELECT [codigo], [nome], [email], [telefone] FROM [Clientes]" UpdateCommand="UPDATE [Clientes] SET [nome] = @nome, [email] = @email, [telefone] = @telefone WHERE [codigo] = @codigo">
        <DeleteParameters>
            <asp:Parameter Name="codigo" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="nome" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="telefone" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="nome" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="telefone" Type="String" />
            <asp:Parameter Name="codigo" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
</asp:Content>

