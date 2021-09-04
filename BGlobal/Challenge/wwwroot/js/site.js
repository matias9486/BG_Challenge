// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

    $(document).ready(function(){


        for (let i = 1; i <= 2; i++) {
            $.ajax({

                url: "https://reqres.in/api/users?page="+i,
                type: "get",

                success: function (response) {

                    $.each(response.data, function (i, val) {                        
                        $("#Titular").append("<option>" + val.last_name + ", " + val.first_name + "</option>");
                    });
                }
            });
        }
        


});