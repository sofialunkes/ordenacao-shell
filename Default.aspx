﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Index.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="principal">
        <div class="container-fluid">
            <div class="row">
                <div class=" col-lg-7 col-lg-offset-2">
                    <ul class="nav nav-tabs" role="tablist">
                        <li role="presentation" class="active"><a href="#cadastro" aria-controls="cadastro" role="tab" data-toggle="tab">Cadastro</a></li>
                        <li role="presentation"><a href="#jogo" aria-controls="jogo" role="tab" data-toggle="tab">Jogos</a></li>
                        <li role="presentation"><a href="#ordenacao" aria-controls="ordenacao" role="tab" data-toggle="tab">Ordenar</a></li>
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
                                                <h4>ID:</h4>
                                                <asp:TextBox ID="txtNumConta" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
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
                                            <h4>Jogos:</h4>

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
                            <br />
                            <table class="table table-hover">
                                <thead>
                                    <tr>
                                        <th>Jogo</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Label ID="lblJogosCadastrados" runat="server"></asp:Label>
                                </tbody>
                            </table>
                        </div>
                        <div class="tab-pane fade" id="ordenacao">
                            <asp:Button runat="server" Text="Select"/>
                            <asp:Button runat="server" Text="Ordenar" ID="btnOrdenar" OnClick="btnOrdenar_Click"/>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3">
                    <h4>Contas Cadastradas</h4>
                    <table class="table table-hover">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Nome</th>
                                <th>Idade</th>
                                <th>Sexo</th>
                                <th>Nick</th>
                                <th>Data Hora</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Label ID="lblInformacoesJogador" runat="server"></asp:Label>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
