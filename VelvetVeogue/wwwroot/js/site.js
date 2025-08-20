// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Add Items page

///
/// No need the following code. Because, we can use placeholder attribute to do the following function. Placeholder
/// attribute is buildin feature in HTML
///

// This code is used to clear and retype the text boxes value (hint | ex: label- category code, text box - category  code)
// Category code
//$("#valueChanging01").click(

//    function () {

//        $("#valueChanging01").val("");
//    }

//);

//$("#valueChanging01").mouseleave(

//    function () {

//        var existing_val = "";
//        existing_val = $("#valueChanging01").val();

//        if (existing_val === "" ) {

//            $("#valueChanging01").val("Category code");
//        }


//    }

//);

//// Category name
//$("#valueChanging02").click(

//    function () {

//        $("#valueChanging02").val("");
//    }

//);

//$("#valueChanging02").mouseleave(

//    function () {

//        $("#valueChanging02").val("Category Name");
//    }

//);

//// Name
//$("#valueChanging03").click(

//    function () {

//        $("#valueChanging03").val("");
//    }

//);

//$("#valueChanging03").mouseleave(

//    function () {

//        $("#valueChanging03").val("Name");
//    }

//);


//// Color
//$("#valueChanging04").click(

//    function () {

//        $("#valueChanging04").val("");
//    }

//);

//$("#valueChanging04").mouseleave(

//    function () {

//        $("#valueChanging04").val("Color");
//    }

//);


//// Size
//$("#valueChanging05").click(

//    function () {

//        $("#valueChanging05").val("");
//    }

//);

//$("#valueChanging05").mouseleave(

//    function () {

//        $("#valueChanging05").val("Size");
//    }

//);


//// Available Qty
//$("#valueChanging06").click(

//    function () {

//        $("#valueChanging06").val("");
//    }

//);

//$("#valueChanging06").mouseleave(

//    function () {

//        $("#valueChanging06").val("Available Qty");
//    }

//);


//// Price
//$("#valueChanging07").click(

//    function () {

//        $("#valueChanging07").val("");
//    }

//);

//$("#valueChanging07").mouseleave(

//    function () {

//        $("#valueChanging07").val("Price");
//    }

//);

///
/// Sign up page
///

$("#btnSave").on("click",

    function () {

      
        //var username = "";
        //var password = "";
        //var confirmPW = "";

        //username = $("#username").val();
        //password = $("#password").val();
        //confirmPW = $("#confirmpw").val();

        //if (username === "") {
        //    alert("!!Please enter the username!!");

        //}
        //else if (password === "") {

        //    alert("!!Please enter the password!!");
        //}
        //else if (confirmPW === "") {

        //    alert("!!Please fill the confirm password!!");
        //}
        //else if (password != confirmPW) {

        //    alert("The Password and confirm password does not matched");

        //}
    }

);

// Opening file explorer
$("#btnbrowes").on("click",

    function () {

        $("#FileInput").trigger("click");

    }

);

  