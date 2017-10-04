<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />

    <button class="btn btn-primary">Add</button>

    <br />
    <br />

    <div class="row">
        <table class="table table-hover">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>DOB</th>
                    <th>Address</th>
                    <th>Email</th>
                    <th>Number</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td runat="server"><%=vm.Name %></td>
                    <td>06/03/93</td>
                    <td>Malta</td>
                    <td>john@example.com</td>
                    <td>79205997</td>
                </tr>
                <tr>
                    <td>Mary May</td>
                    <td>11/12/87</td>
                    <td>Germany</td>
                    <td>mary@example.com</td>
                    <td>55447828</td>
                </tr>

            </tbody>
        </table>
    </div>
</asp:Content>
