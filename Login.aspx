<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login AGAMENNONE</title>
    <link href="assets/css/login.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
</head>
<body>
    <%--background--%>
    <div id="bg">
        <img src="assets/images/login/background.jpg" />
    </div>
    <%--background--%>
    <%--login form--%>
    <form runat="server">
        <div class="logo">
            <img src="assets/images/logo.png" />
        </div>
        <div>
            <div class="form-field">
                <input type="email" placeholder="Email / Username" />
            </div>

            <div class="form-field">
                <input type="password" placeholder="Password" />
            </div>

            <div class="form-field">
                <button class="btn" type="submit">Log in</button>
            </div>
        </div>
    </form>
    <%--login form--%>
</body>
</html>
