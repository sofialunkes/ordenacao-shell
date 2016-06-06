<%@ Page Title="" Language="C#" MasterPageFile="~/Index.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="principal">
        <div class="container-fluid">
            <div class="row">
                <div class=" col-lg-8 col-lg-offset-2">
                    <ul class="nav nav-tabs" role="tablist">
                        <li role="presentation" class="active"><a href="#cadastro" aria-controls="cadastro" role="tab" data-toggle="tab">Cadastro</a></li>
                        <li role="presentation"><a href="#jogo" aria-controls="jogo" role="tab" data-toggle="tab">Jogos</a></li>
                    </ul>
                    <div class="tab-content">
                        <div role="tabpanel" class="tab-pane  fade in active" id="cadastro">
                            <div class="row">
                                <div class="col-lg-10">
                                    <div class="row">
                                        <div class="col-lg-10 col-lg-offset-1">
                                            <div class="form-group">
                                                <h4>Nome:</h4>
                                                <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-10 col-lg-offset-1">
                                            <div class="form-group">
                                                <h4>Idade</h4>
                                                <asp:TextBox runat="server" ID="txtIdade" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-10 col-lg-offset-1">
                                            <h4>Sexo:</h4>
                                            <asp:DropDownList runat="server" ID="ddlSexo" CssClass="form-control">
                                                <asp:ListItem></asp:ListItem>
                                                <asp:ListItem Value="F">Feminino</asp:ListItem>
                                                <asp:ListItem Value="M">Masculino</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-10 col-lg-offset-1">
                                            <h4>Nick:</h4>
                                            <asp:TextBox runat="server" CssClass="form-control" ID="txtNick"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-10 col-lg-offset-1">
                                            <br />
                                            <asp:Button ID="btnLimparCadastro" runat="server" CssClass="btn btn-danger btn-lg col-lg-6" Text="Limpar" OnClick="btnLimparCadastro_Click" />
                                            <asp:Button ID="btnCadastrarJogador" runat="server" CssClass="btn btn-success btn-lg col-lg-6" Text="Cadastrar" OnClick="btnSalvarJogador_Click" /><br />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div role="tabpanel" class="tab-pane fade" id="jogo">
                            <asp:CheckBoxList runat="server" ID="cblJogos">
                                <asp:ListItem></asp:ListItem>
                            </asp:CheckBoxList>
                        </div>
                    </div>
                </div>
                <div class="col-lg-2 side-panel">
                    <h4>Contas Cadastradas</h4>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

