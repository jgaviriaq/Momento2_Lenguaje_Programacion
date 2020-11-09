﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestRuta.aspx.cs" Inherits="Vista.gestRuta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Concesionario</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="index.html">Concesionario</a>
    </nav>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" href="gestTipoVehiculo.aspx">Registro Tipo Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestVehiculo.aspx">Vehiculo</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestTipoConductor.aspx">Tipo Conductor</a>
                </li>
                <li class="nav-item ">
                    <a class="nav-link" href="gestConductor.aspx">Registro Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestContrato.aspx">Contrato</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="gestRuta.aspx">Ruta</a>
                </li>
            </ul>
        </div>
    </nav>

    <div class="container">
        <br />
        <h1>Gestión Ruta</h1>
        <br />

        <form id="form1" runat="server">
            <div class="form-group">
                <label for="txtId">Id</label>
                <asp:TextBox ID="txtId" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtestacion">Estacion</label>
                <asp:TextBox ID="txtestacion" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtId_Vehiculo">Id Vehiculo</label>
                <asp:TextBox ID="txtId_Vehiculo" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-row">
                <div class="col-8">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click" />
                </div>
                <div class="col-4 text-right">
                    <asp:Button ID="btnList" runat="server" Text="List" class="btn btn-primary" OnClick="btnList_Click"  />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click"  />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-primary" OnClick="btnDelete_Click" />

                </div>
            </div>

            <div class="form-row">
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Blue" EnableViewState="false"></asp:Label>
            </div>

            <br />

            <table class="table">
                <tr>
                    <th>
                        <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="Id" />
                                <asp:BoundField DataField="estacion" HeaderText="Estacion" />
                                <asp:BoundField DataField="id_vehiculo" HeaderText="Id Vehiculo" />
                            </Columns>
                        </asp:GridView>
                    </th>
                </tr>
            </table>
        </form>

    </div>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

</body>
</html>
