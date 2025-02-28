﻿<%@ Page Title="Личный кабинет" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cabinet.aspx.cs" Inherits="Rentoolo.Account.Cabinet" %>

<%@ Import Namespace="Rentoolo.Model" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="additem">
        <div class="additem-logo">
            <h4><%: Title %></h4>
        </div>
        <div class="additem-category">
            <div class="additem-right additem__way" cid="1001">
                <table class="marginTable cabinetTable">
                    <tr>
                        <td>
                            <br />
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td colspan="3">Реферальная ссылка:</td>
                    </tr>
                    <tr>
                        <td colspan="3" class="height: 50px;">
                            <input id="refferalLink" onclick="copyToClipboardUrl()" type="text" style="height: 20px; border: none; background: transparent; color: #181A1C; font-size: 17px; width: 400px; -webkit-appearance: none; box-shadow: inset 0px 0px 0px 0px red; cursor: pointer;" title="Скопировать" value="<%=Helper.GetRefferalLink(Request, this.User.PublicId) %>" />
                        </td>
                    </tr>
                    <tr>
                        <td>Баланс:
                        </td>
                        <td>0р. <a href="#" title="Пополнить">Пополнить</a>
                        </td>
                    </tr>
                </table>
                <div style="padding-top: 15px;">
                    <a href="Settings.aspx" class="button-changePassword settingButton">Настройки</a>
                </div>
                <div style="padding-top: 15px;">
                    <a href="Manage.aspx" class="button-changePassword settingButton">Сменить пароль</a>
                </div>
                <div style="padding-top: 15px;">
                    <a href="/Tokens.aspx" class="button-changePassword settingButton">Токены</a>
                </div>
                <div style="padding-top: 15px;">
                    <a href="/Account/TokensBuying.aspx" class="button-changePassword settingButton">История покупок токенов</a>
                </div>
                <div style="padding-top: 15px;">
                    <a href="/Account/TokensSelling.aspx" class="button-changePassword settingButton">История продаж токенов</a>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">

        function copyToClipboardUrl() {
            var copyText = document.getElementById("refferalLink");
            copyText.select();
            document.execCommand("copy");
        }

        function copyToClipboardAccountId() {
            var copyText = document.getElementById("accountId");
            copyText.select();
            document.execCommand("copy");
        }
    </script>
</asp:Content>
