$(document).ready(function () {
    var keyBox = $("#keyBox").val();
    var keyPhongBan = $("#keyPhongBan").val();
    
    
    for (var i = parseInt($("#pageNumber").val()); i > 0; i--) {
        var li = "<li class='page-item' id='p-" + (i ).toString() + "'><button class='page-link'>" + (i ).toString() + "</button></li>";
        $("#passList").after(li);
    }
    var currentPage = $("#currentPage").val();
    var value = parseInt(currentPage.substring(2)) - 1;
    if (parseInt($("#pageNumber").val()) == 1) {
        $("#passList").addClass("disabled");
        $("#nextList").addClass("disabled");
    }
    else if (value == 0) {
        $("#passList").addClass("disabled");
    }
    else if (value == parseInt($("#pageNumber").val())) {
        $("#nextList").addClass("disabled");
    }
    $.ajax({
        type: "Post",
        url: "/staff/GetPage",
        data: { pageIndex: parseInt(value), keyPhongBan: keyPhongBan, keyBox: keyBox  },
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
            $("#passList").addClass("disabled");
            $("#nextList").removeClass("disabled");
        }
        else if (pageIndex == $("#pageNumber").val() -1) {
            $("#nextList").addClass("disabled");
            $("#passList").removeClass("disabled");
        }
        else {
            $("#passList").removeClass("disabled");
            $("#nextList").removeClass("disabled");
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

    $("#passList a").click(function (event) {

        $("#" + currentPage + " button").removeClass("bg-primary text-white active");
        currentPage = currentPage.substring(0, 2) + (parseInt(currentPage.substring(2)) - 1).toString();
        $("#" + currentPage + " button").addClass("bg-primary text-white active");
        var pageIndex = parseInt(currentPage.substring(2)) - 1;
        if (pageIndex == 0) {
            $("#passList").addClass("disabled");
            $("#nextList").removeClass("disabled");
        }
        else if (pageIndex == $("#pageNumber").val()) {
            $("#nextList").addClass("disabled");
            $("#passList").removeClass("disabled");
        }
        else {
            $("#passList").removeClass("disabled");
            $("#nextList").removeClass("disabled");
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
    $("#nextList a").click(function (event) {

        $("#" + currentPage + " button").removeClass("bg-primary text-white active");
        currentPage = currentPage.substring(0, 2) + (parseInt(currentPage.substring(2)) + 1).toString();
        $("#" + currentPage + " button").addClass("bg-primary text-white active");
        var pageIndex = parseInt(currentPage.substring(2)) - 1;
        if (pageIndex == 0) {
            $("#passList").addClass("disabled");
            $("#nextList").removeClass("disabled");
        }
        else if (pageIndex == $("#pageNumber").val() -1) {
            $("#nextList").addClass("disabled");
            $("#passList").removeClass("disabled");
        }
        else {
            $("#passList").removeClass("disabled");
            $("#nextList").removeClass("disabled");
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
});

