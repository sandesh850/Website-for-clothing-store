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

///
/// Add item page
///

// Opening file explorer
$(document).ready(function () {

    $("#btnbrowes").on("click",

        function () {

            $("#FileInput").trigger("click");

        }

    );

    $("#FileInput").on("change",function (event) {

        var file = event.target.files[0];

        if (file) {

            var fileReader = new FileReader; // JavaScript build in libery that use to reade files

            fileReader.onload = function (e) {

                $("#imgPreview").attr("src", e.target.result);
            }

            fileReader.readAsDataURL(file);

        }
        else {
            alert("No file selected");
        }


    });

});

//Payment and order placing page
$("#SelectedPaymentMethod").on("change", function () {

    var selectedMethod = $("#SelectedPaymentMethod").val()

    if (selectedMethod === "Cash On Delivery") {

        $("#BottomPartOfTheCard").html(
            '<div class="col-12 text-end">' +
            ' <button type="submit" class="btn btn-primary"> Place Order </button> ' +
            '</div > '
        );





    }
    else if (selectedMethod === "Online Payment") {

        $("#BottomPartOfTheCard").html(
           
            '<div class="col-12">'

                      
                        +'<div class="row">'
                            +'<div class="col-3">'
                               +' <label>Card No</label>'
                            +'</div>'
                           +' <div class="col-9">'
            + ' <input type="text" name="tbxcardNo" placeholder="Card No" class="form-control"/>'
           
                            +'</div>'
                        +'</div>'

                       
                        +'<div class="row pt-3">'
                           
                            +'<div class="col-3">'
                               +' <label>Date</label>'
                            +'</div>'
                            +'<div class="col-3">'
            +'<input type="text" name="tbxcardDate" placeholder="MM/YY" class="form-control" />'
                           +' </div>'

                            +'<!--CVC NO-->'
                            +'<div class="col-2">'
                                +'<label>CVC NO</label>'
                            +'</div>'
                           +' <div class="col-4">'
            +'<input type="text" name="tbxcvcNo" style="width:40%" placeholder="000" class="form-control" />'
                            +'</div>'

                        +'</div>'

                    
                    +'<div class="row pt-4 text-end">'
                        +'<div class="col-12">'
                            +'<button type="submit" style="width:30%" class="btn btn-primary"> Place Order </button>'
                        +'</div>'

                     +'</div>'
                       
                +'</div > '
        );
    }

});


  