$(document).ready(function () {
    var keyBox = $("#keyBox").val();
    var keyPhongBan = $("#keyPhongBan").val();
   
    
    for (var i = parseInt($("#pageNumber").val()); i > 0; i--) {
        var li = "<li class='page-item' id='" + (i).toString() + "'><button class='page-link'>" + (i ).toString() + "</button></li>";
        $("#startList").after(li);
    }
    var pageNumberCheck = $("#pageNumber").val();
    var pageNumber = $("#pageNumber").val();
    var value = parseInt($("#pageNumber").val());
    console.log(value);
    if (parseInt($("#pageNumber").val()) == 1) {
        $("#startList").addClass("disabled");
        $("#endList").addClass("disabled");
    }
    else if (value == 0) {
        $("#startList").addClass("disabled");
    }
    else if (value == parseInt($("#pageNumber").val())) {
        $("#endList").addClass("disabled");
    }
    $.ajax({
        type: "Post",
        url: "/staff/GetPage",
        data: { pageIndex: value, keyPhongBan: keyPhongBan, keyBox: keyBox  },
        dataType: "text",
        success: function (data) {
            $("#StaffTable").html(data);
        },
        error: function (req, status, error) {
            console.log(error);

        }
    });

    $("#" + pageNumber + " button").addClass("bg-primary text-white active");

    $("li button").click(function () {
        pageNumber = $(this).parent().attr("id");
       
        
        $("button").removeClass("bg-primary text-white active");
        
        
        $(this).addClass("bg-primary text-white active");
        var pageIndex = parseInt(pageNumber);
       
        console.log("pageIndex " + pageIndex);
        if (pageIndex == 1) {
            $("#startList").addClass("disabled");
            $("#endList").removeClass("disabled");
        }
        else if (pageIndex == pageNumberCheck ) {
            $("#endList").addClass("disabled");
            $("#startList").removeClass("disabled");
        }
        else {
            $("#startList").removeClass("disabled");
            $("#endList").removeClass("disabled");
        }
        $.ajax({
            type: "Post",
            url: "/staff/GetPage",
            data: { pageIndex: parseInt(pageIndex), keyPhongBan: keyPhongBan, keyBox: keyBox },
            dataType: "text",
            success: function (data) {
                $("#StaffTable").html(data);
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });


    });

    $("#startList a").click(function (event) {
        
        $(" button").removeClass("bg-primary text-white active");
       
        $("#" + 1 + " button").addClass("bg-primary text-white active");
        var pageIndex = 1;
        
            $("#startList").addClass("disabled");
            $("#endList").removeClass("disabled");
        
       
        $.ajax({
            type: "Post",
            url: "/staff/GetPage",
            data: { pageIndex: parseInt(pageIndex), keyPhongBan: keyPhongBan, keyBox: keyBox },
            dataType: "text",
            success: function (data) {
                $("#StaffTable").html(data);
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });

    });
    $("#endList a").click(function (event) {
        var pageIndex = parseInt(pageNumberCheck);
        $(" button").removeClass("bg-primary text-white active");
        console.log("pageNumber   " + pageIndex);
        
       

        $("#endList").addClass("disabled");
        $("#startList").removeClass("disabled");


        $.ajax({
            type: "Post",
            url: "/staff/GetPage",
            data: { pageIndex: pageIndex, keyPhongBan: keyPhongBan, keyBox: keyBox },
            dataType: "text",
            success: function (data) {
                $("#StaffTable").html(data);
            },
            error: function (req, status, error) {
                console.log(error);

            }
        }); 
        $("#" + pageIndex + " button").addClass("bg-primary text-white active");
        
    });
});

