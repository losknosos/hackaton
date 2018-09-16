﻿"use strict";

window.SaleViewer = window.SaleViewer || {};

SaleViewer.TopMenu = function (container, selected, dashboardHeader) {

    var SUBMENU_DELTA_WIDTH = 4,
        DEFAULT_TOP_SIZE = 250,
        MENU_CLASS = "top-menu-item",
        SUBMENU_CLASS = "top-submenu-item",
        NOT_LAST_CLASS = "not-last",
        FIRST_CLASS = "top-menu-first";

    var menuItems = [
        //    {
        //    id: "Dashboard",
        //    text: "Dashboard",
        //    first: true,
        //    items: [{
        //        sub: true,
        //        topSize: 273,
        //        text: "Revenue by Product",
        //        link: "/Dashboard/Products"
        //    }, {
        //        sub: true,
        //        topSize: 262,
        //        text: "Revenue by Sector",
        //        link: "/Dashboard/Sectors"
        //    }, {
        //        sub: true,
        //        last: true,
        //        topSize: 282,
        //        text: "Revenue by Channels",
        //        link: "/Dashboard/Channels"
        //    }]
        //},
        {
            id: "Campañas",
            text: "Campañas",
            link: "/Campaigns"
        },
        {
            id: "Productos",
            text: "Productos",
            link: "/Products"
        },
        {
            id: "Transacciones",
            text: "Transacciones",
            link: "/Sales"
        }, {
            id: "ConsultaCliente",
            text: "Consulta Cliente",
            link: "/Customers"
        }];

    function initMenu() {
        $(container).dxMenu({
            dataSource: menuItems,
            height: 60,
            activeStateEnabled: false,

            cssClass: "top-menu",
            selectionMode: "single",
            showFirstSubmenuMode: {
                name: "onHover"
            },
            hideSubmenuOnMouseLeave: true,
            itemTemplate: function (menuItem) {
                var div = $("<div/>", {
                    "class": menuItem.sub ? SUBMENU_CLASS : MENU_CLASS,
                    "text": menuItem.text
                });

                if (menuItem.id == selected) {
                    $(container).dxMenu("instance").option("selectedItem", menuItem);
                }

                if (menuItem.first) {
                    div.addClass(FIRST_CLASS);
                    var topSize = DEFAULT_TOP_SIZE;
                    if (dashboardHeader !== "") {
                        div.text("Dashboard: " + dashboardHeader);
                        $.each(menuItem.items, function (index, item) {
                            if (item.text === dashboardHeader) {
                                topSize = item.topSize;
                                return false;
                            }
                        });
                    }
                    div.css("width", topSize);
                }
                if (menuItem.sub) {
                    if (!menuItem.last) div.addClass(NOT_LAST_CLASS);
                    div.css("width", (menuItem.text == dashboardHeader ? $("." + FIRST_CLASS).outerWidth() : DEFAULT_TOP_SIZE) - SUBMENU_DELTA_WIDTH);
                }

                return div;
            },
            onItemClick: function (e) {
                var link = e.itemData.link;
                if (link) {
                    window.location = SaleViewer.baseApiUrl + link;
                    window.location = "http://localhost:5000" + link;                    
                }
            }
        });
    }

    this.init = function () {
        $(function () {
            initMenu();
        });
    };

};