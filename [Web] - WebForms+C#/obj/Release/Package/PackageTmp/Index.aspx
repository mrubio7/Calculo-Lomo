<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebCalculoLomo.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora lomo</title>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Montserrat&display=swap');
        .texthead {
            color: #141414;
            text-align: center;
            font-family: 'Montserrat', sans-serif;
        }
        .heading {
            line-height: 60px;
            width: 400px;
            height: 60px;
            background-color: #006bff;
            margin-left: auto;
            margin-right: auto;
            justify-content: center;
            align-items: center;
            border-top-left-radius:7px;
            border-top-right-radius:7px;
            border-bottom: 3px solid #002558;
        }
        .box_one {
            margin-left: auto;
            margin-right: auto;
            justify-content: space-between;
            background-image: linear-gradient(#FFFFFF, #C7C7C7);
            padding-top: 15px;
            width: 400px;
            height: 220px;
        }
        .box_one > div {
            margin-left:auto;
            margin-right:auto;
            width: 350px;
        }
        .box_one > div > div {
            width: 160px;
            height: 50px;
            padding-top: 10px;
            font-size-adjust: 0.5;
            color: #006bff;
            text-align: left;
            font-family: 'Montserrat', sans-serif;
            font-size:12px;
        }
        footer {
            width: 400px;
            margin-left: auto;
            margin-right: auto;
            color: #727272;
            font-family: 'Montserrat', sans-serif;
            text-align: right;
            font-size: 10px;
            background-color: #002558;
            border-bottom-left-radius:7px;
            border-bottom-right-radius:7px;
        }
        .btn {
            align-items: center;
        }
        .result {
            padding-top: 20px;
            font-family: 'Montserrat', sans-serif;
            font-size: 14px;
            font-weight:bold;
            text-align:center;
            color: #006bff;
            text-size-adjust:auto;
        }
    </style>
</head>
<body style="background-color: #141414">
        <form id="form1" runat="server">
        <header class="heading">
            <h1 class="texthead">Calculadora de lomo</h1>
        </header>
        <section class="box_one">
			<div >
                <div style="float:left">Nº Páginas:<br/> <asp:TextBox ID="TextBox_NPag" runat="server" Width="150px" Height="20px"></asp:TextBox></div>
                <div style="float:right; width:160px;">Papel:<br/> <asp:DropDownList ID="DropDownList_Papel" runat="server" style="width: 160px" Height="26px">
					<asp:ListItem Value="0">Estucado</asp:ListItem>
					<asp:ListItem Value="1">Offset</asp:ListItem>
					<asp:ListItem Value="2">Offset Volumen</asp:ListItem>
					</asp:DropDownList></div>
                <div style="float:left">Gramaje:<br/> <asp:TextBox ID="TextBox_Gramaje" runat="server" Width="150px" Height="20px"></asp:TextBox></div>
                <div style="float:right; width:160px;">Encuadernación:<br/> <asp:DropDownList ID="DropDownList_Enc" runat="server" style="width: 160px" Height="26px">
					<asp:ListItem Value="0">Hilo</asp:ListItem>
					<asp:ListItem Value="1">Fresado</asp:ListItem>
					</asp:DropDownList></div>
            </div>
            <div class="btn"><asp:Button ID="Calcular" runat="server" Text="Calcular" Height="30px" Width="350px" style="margin-top: 20px" OnClick="OnClick_Calcular"/></div>
            <div class="result"><asp:Label ID="Result" runat="server" Text=""></asp:Label></div>
        </section>
        <footer>
            This was made by <a href="https://www.linkedin.com/in/manuelrubioarias" style="color: #727272">Manuel Rubio</a>.
        </footer>
    </form>
</body>
</html>
