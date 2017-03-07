// JavaScript Document
//支持Enter键登录
		document.onkeydown = function(e){
			if($(".bac").length==0)
			{
				if(!e) e = window.event;
				if((e.keyCode || e.which) == 13) {
				    var obtnLogin = document.getElementById("submit_btn");
					obtnLogin.focus();
				}
			}
		}

    	$(function(){
			//提交表单
			$('#submit_btn').click(function(){
				show_loading();
				//var myReg = /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/; //邮件正则
				if($('#UName').val() == ''){
					show_err_msg('用户名还没填呢！');	
					$('#UName').focus();
				} 
                //else if (!myReg.test($('#UName').val())) {
				//	show_err_msg('您的邮箱格式错咯！');
				//	$('#UName').focus();
			    //}
			    else if($('#password').val() == ''){
					show_err_msg('密码还没填呢！');
					$('#password').focus();
				}else{
					//ajax提交表单，#login_form为表单的ID。 如：$('#login_form').ajaxSubmit(function(data) { ... });
			        LoginUserInfo();
				    ClickRemoveChangeCode();
				}
			});
    	});

		function LoginUserInfo() {
		    var postData = {
		        UName: $("#UName").val(),
		        Pwd: $("#password").val(),
		        code: $("#j_captcha").val()
		    };
		    $.post("",
		        postData,
		        function(data) {
		            if (data == "OK") {
		                show_msg('登录成功咯！  正在为您跳转...', '/');
		                widows.location.href = "/UserInfo/GetAllUserInfos";
		            } else {
		                alert(data);
		                window.location.href = "/Login/Index";
		            }
		        });
		}