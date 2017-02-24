﻿
$(function () {

    //当页面首次刷新的时候执行的事件

    initTable();

});

//实现对DataGird控件的绑定操作

function initTable() {

    $('#test').datagrid({   //定位到Table标签，Table标签的ID是test

        //   UserInfo是控制器，GetAllUserInfos是控制器中获取用户数据的一个Action

        url: '/UserInfo/GetAllUserInfos',   //指向后台的Action来获取当前用户的信息的Json格式的数据

        title: '用户的展示',  //标识

        //下面的这些属性如果谁不太清楚的话我建议去官方网站去学习或者在群里我们讨论，这里就不说了
        
        iconCls: 'icon-save',

        width: 500,

        height: 350,

        nowrap: true,

        autoRowHeight: false,

        striped: true,

        collapsible: true,

        pagination: true,

        rownumbers: true,

        sortName: 'Id',

        sortOrder: 'desc',

        remoteSort: false,

        idField: 'Id',

        frozenColumns: [[

            { field: 'ck', checkbox: true },

            { title: '主键', field: 'Id', width: 100, sortable: true },

            { title: '用户名', field: 'UName', width: 120, sortable: true },

            { title: '密码', field: 'Pwd', width: 100, sortable: true }

        ]],

        toolbar: [{

            id: 'btnadd',

            text: '添加',

            iconCls: 'icon-add',

            handler: function () {

                $('#btnsave').linkbutton('enable');

            }

        }, {

            id: 'btncut',

            text: '修改',

            iconCls: 'icon-cut',

            handler: function () {

                $('#btncut').linkbutton('enable');

            }

        }, '-', {

            id: '删除',

            text: 'Save',

            iconCls: 'icon-cancel',

        }]

    });

}