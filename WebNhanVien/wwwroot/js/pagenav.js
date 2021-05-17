$(document).ready(function () {
    var ageMin = $("#ageMin").val();
    var ageMax = $("#ageMax").val();
   
    var keyBox = $("#keyBox").val();
    var keyPhongBan = $("#keyPhongBan").val();
   /* console.log("keyPhongBan o pagenav= " + keyPhongBan);
    console.log("so trang= " + parseInt($("#TemppageNumber").val()));
    console.log("so trang theo curent= " + parseInt($("#currentPage").val().substring(2)));*/
    
    for (var i = parseInt($("#TemppageNumber").val()); i > 0; i--) {
        var li = "<li class='page-item' id='p-" + (i ).toString() + "'><button class='page-link'>" + (i ).toString() + "</button></li>";
        $("#startList").after(li);
    }
    var currentPage = $("#currentPage").val();
    var value = parseInt(currentPage.substring(2)) - 1;
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
        data: { pageIndex: parseInt(value), keyPhongBan: keyPhongBan, keyBox: keyBox , ageMin:ageMin, ageMax:ageMax },
        dataType: "text",
        success: function (data) {
            $("#StaffTable").html(data);
        },
        error: function (req, status, error) {
            console.log(error);

        }
    });

    $("#" + currentPage + " button").addClass("bg-primary text-white active");

    $("li button").click(function () {
        $("#" + currentPage + " button").removeClass("bg-primary text-white active");
        currentPage = $(this).parent().attr("id");
        $(this).addClass("bg-primary text-white active");
        var pageIndex = parseInt(currentPage.substring(2)) - 1;
        console.log($("#pageNumber").val());
        console.log(pageIndex);
        if (pageIndex == 0) {
            $("#startList").addClass("disabled");
            $("#endList").removeClass("disabled");
        }
        else if (pageIndex == $("#pageNumber").val() -1) {
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
            data: { pageIndex: parseInt(pageIndex), keyPhongBan: keyPhongBan, keyBox: keyBox, ageMin: ageMin, ageMax: ageMax},
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
        var tmp = parseInt($("#pageNumber").val()) -1;
        $("#" + currentPage + " button").removeClass("bg-primary text-white active");
        currentPage = currentPage.substring(0, 2) + "1";
        console.log(tmp);
        console.log(currentPage);
        $("#" + currentPage + " button").addClass("bg-primary text-white active");
        var pageIndex = parseInt(currentPage.substring(2)) - 1;
        
            $("#startList").addClass("disabled");
            $("#endList").removeClass("disabled");
        
       
        $.ajax({
            type: "Post",
            url: "/staff/GetPage",
            data: { pageIndex: parseInt(pageIndex), keyPhongBan: keyPhongBan, keyBox: keyBox, ageMin: ageMin, ageMax: ageMax },
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
        var tmp = parseInt($("#pageNumber").val()) ;
        $("#" + currentPage + " button").removeClass("bg-primary text-white active");
        currentPage = currentPage.substring(0, 2) + tmp.toString();
        $("#" + currentPage + " button").addClass("bg-primary text-white active");
        var pageIndex = parseInt(currentPage.substring(2)) - 1;
       
            $("#endList").addClass("disabled");
            $("#startList").removeClass("disabled");
       
        $.ajax({
            type: "Post",
            url: "/staff/GetPage",
            data: { pageIndex: parseInt(pageIndex), keyPhongBan: keyPhongBan, keyBox: keyBox, ageMin: ageMin, ageMax: ageMax },
            dataType: "text",
            success: function (data) {
                $("#StaffTable").html(data);
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });

    });
});

