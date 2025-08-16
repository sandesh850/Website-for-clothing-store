// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Add Items page

// This code is used to clear and retype the text boxes value (hint | ex: label- category code, text box - category  code)
$("#valueChanging").click(

    function () {

        $("#valueChanging").val("");
    }

);

$("#valueChanging").mouseleave(

    function () {

        $("#valueChanging").val("Category code");
    }

);