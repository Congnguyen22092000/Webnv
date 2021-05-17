

$(document).ready(function () {
    var changeMin = false;
    var changeMax = false;
    var ageMin = $("#minAge").val();
    var ageMax = $("#maxAge").val();
    var searchBox = $("#SearchBox").val().toLowerCase();
    var searchPhongBan = $("#check").val();
    var value = "p-1";

    //Gọi trang đầu===========================================================
    if ($("#pagenav").val() == "") {
        $.ajax({
            type: "Post",
            url: "/staff/PageNav",
            data: { currentPage: value, keyPhongBan: searchPhongBan, keyBox: searchBox, ageMin: ageMin, ageMax: ageMax },
            dataType: "text",
            success: function (data) {

                $("#pagenav").html(data);

            },
            error: function (req, status, error) {
                console.log(error);

            }
        });
    }
    
    
    
    //check phòng ban==========================================================
    $("#check").change(function () {
         ageMin = $("#minAge").val();
        ageMax = $("#maxAge").val();
        searchBox = $("#SearchBox").val().toLowerCase();
        searchPhongBan = $("#check").val();
        console.log(searchPhongBan);
        $.ajax({
            type: "Post",
            url: "/staff/PageNav",
            data: { currentPage: value, keyPhongBan: searchPhongBan, keyBox: searchBox, ageMin: ageMin, ageMax: ageMax },
            dataType: "text",
            success: function (data) {
                /*$("#StaffTable").empty();*/
                $("#pagenav").html(data);
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });
    });


    //Sự kiện tìm kiếm====================================================
    $("#SearchBox").on("keyup", function () {
        ageMin = $("#minAge").val();
        ageMax = $("#maxAge").val();
        searchBox = $("#SearchBox").val().toLowerCase();
        searchPhongBan = $("#check").val();
        console.log(searchBox);
        
        $.ajax({
            type: "Post",
            url: "/staff/PageNav",
            data: { currentPage: value, keyPhongBan: searchPhongBan, keyBox: searchBox, ageMin: ageMin, ageMax: ageMax },
            dataType: "text",
            success: function (data) {
               
                $("#pagenav").html(data);
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });

    });

    //TÌm kiếm theo tuổi===================================================
    $("#searchHight").click(function () {
        console.log("da vao tim kiem theo tuoi");
        $("#searchTuoi").prop("hidden", false);
        
        //out click====================
        
        
    });
    $("#minAge").blur(function () {
        changeMin = true;
        ageMin = $("#minAge").val();
        console.log("check change min");
        if (ageMin < 0) {
            alert("Số tuổi không thể là âm, vui lòng nhập lại!");
        }
        
    });
    $("#maxAge").blur(function () {
        changeMax = true;
        ageMax = $("#maxAge").val();
        console.log("check change max");
        if (ageMax < 0) {
            alert("Số tuổi không thể là âm, vui lòng nhập lại!");
        }
    });
    //out tim kiem Age===============
    $("#outSearchAge").click(function () {
        $("#minAge").val(0)  ;
        $("#maxAge").val(100) ;
        console.log("da vao out tuoi");
        $("#searchTuoi").prop("hidden", true);
        $.ajax({
            type: "Post",
            url: "/staff/PageNav",
            data: { currentPage: value, keyPhongBan: searchPhongBan, keyBox: searchBox, ageMin: 0, ageMax: 100 },
            dataType: "text",
            success: function (data) {

                $("#pagenav").html(data);
                console.log(ageMin + "  " + ageMax);
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });
    });
    //Submt click=====================
    $("#getAge").click(function () {
        if (changeMin == false & changeMax == true) {
            
            $("#minAge").val(0);
        }
        if (changeMax == false & changeMin == true) {
            $("#maxAge").val(100);
        }
        var ageMin = $("#minAge").val();
        var ageMax = $("#maxAge").val();
        $.ajax({
            type: "Post",
            url: "/staff/PageNav",
            data: { currentPage: value, keyPhongBan: searchPhongBan, keyBox: searchBox, ageMin: ageMin, ageMax: ageMax },
            dataType: "text",
            success: function (data) {

                $("#pagenav").html(data);
                console.log(ageMin + "  " + ageMax);
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });
        console.log(ageMin + "  " + ageMax);
        changeMin = false;
        changeMax = false;
    });
    
    //sự kiện thêm nhân viên===============================================
    var checkHoTen = false;
    var checkDate = false;
    var checkSoDT = false;
    var checkChucVu = false;
    
    $("#myBtn").click(function () {
        var outPhongBan = $("#check").val();
        console.log(outPhongBan);
        $.ajax({
            type: "Post",
            url: "/staff/phongBan",
            data: { name: outPhongBan},
            dataType: "text",
            success: function (data) {

                
                $("#phongBan").html(data);
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });
    });

    $("#hoTen").blur(function () {

        var maNhanVien = $("#maNhanVien").val();
        var hoTen = $("#hoTen").val();
        var ngaySinh = $("#ngaySinh").val();
        var soDT = $("#soDT").val();

        var chucVu = $("#chucVu").val();
        console.log(hoTen);
        if (hoTen == "") {
            checkHoTen = false;
           
            $("#ErrorMgs").text("Bạn bắt buộc phải nhập trường này!");
        }
        else {
            $("#ErrorMgs").text("");
            $.ajax({
                type: "Post",
                url: "/staff/IsDuplicatedStaff",
                data: { maNhanVien: maNhanVien, hoTen: hoTen, ngaySinh: ngaySinh, soDT: soDT, chucVu: chucVu },
                dataType: "json",
                success: function (json) {
                    var a = json;
                    if (a == true) {
                        checkHoTen = false;
                        $("#SubmitBtn").prop("disabled", true);
                        $("#ErrorMgs").text("Nhân Viên Đã Tồn Tại");
                        $("#hoTen").css("border-color", "red");
                        $("#ngaySinh").css("border-color", "red");
                    }
                    if (a == false) {

                        checkHoTen = true;
                        if (checkDate == true && checkSoDT == true && checkChucVu == true) {
                            $("#SubmitBtn").prop('disabled', false);
                        }

                        $("#ErrorMgs").text("");
                        $("#hoTen").css("border-color", "#ced4da");
                        $("#ngaySinh").css("border-color", "#eff1f3");
                    }
                },
                error: function (req, status, error) {
                    console.log(error);

                }


            });
        }
    });
    $("#ngaySinh").blur(function () {

        var maNhanVien = $("#maNhanVien").val();
        var hoTen = $("#hoTen").val();
        var ngaySinh = $("#ngaySinh").val();
        var soDT = $("#soDT").val();

        var chucVu = $("#chucVu").val();
       
        if (ngaySinh == "") {
            checkDate = false;
            $("#ErrorMgsDate").text("Bạn bắt buộc phải nhập trường này!");
        }
        else {
            $("#ErrorMgsDate").text("");
            $.ajax({
                type: "Post",
                url: "/staff/IsDuplicatedStaff",
                data: { maNhanVien: maNhanVien, hoTen: hoTen, ngaySinh: ngaySinh, soDT: soDT, chucVu: chucVu },
                dataType: "json",
                success: function (json) {
                    var a = json;
                    if (a == true) {
                        console.log("check trung true");
                        checkDate = false;
                        $("#SubmitBtn").prop("disabled", true);
                        $("#ErrorMgs").text("Nhân Viên Đã Tồn Tại");
                        $("#hoTen").css("border-color", "red");
                        $("#ngaySinh").css("border-color", "red");
                    }
                    if (a == false) {
                        checkDate = true;
                        if (checkHoTen == true && checkSoDT == true && checkChucVu == true) {
                            $("#SubmitBtn").prop('disabled', false);
                        }
                        /*$("#SubmitBtn").prop('disabled', false);*/
                        /*$("#CreateForm").unbind(event)*/
                        $("#ErrorMgs").text("");
                        $("#hoTen").css("border-color", "#ced4da");
                        $("#ngaySinh").css("border-color", "#ced4da");
                    }
                },
                error: function (req, status, error) {
                    console.log(error);

                }
            });
        }

    });
    $("#soDT").blur(function () {
        var soDT = $("#soDT").val();
        if (soDT == "") {
            checkSoDT = false;
            $("#ErrorMgsSoDT").text("Bạn bắt buộc phải nhập trường này!");
            $("#SubmitBtn").prop("disabled", true);
        }
        else {
            checkSoDT = true;
            if (checkHoTen == true && checkDate == true && checkChucVu == true) {
                $("#SubmitBtn").prop('disabled', false);
            }
            $("#ErrorMgsSoDT").text("");
           
        }
    });
    $("#chucVu").blur(function () {

        var chucVu = $("#chucVu").val();
        console.log(chucVu);
        if (chucVu == "") {
            console.log("Da den day");
            checkChucVu = false;
            $("#ErrorMgsChucVu").text("Bạn bắt buộc phải nhập trường này!");
            $("#SubmitBtn").prop("disabled", true);
        }
        else {
            checkChucVu = true;
            if (checkHoTen == true && checkSoDT == true && checkDate == true) {
                $("#SubmitBtn").prop('disabled', false);
            }
            $("#ErrorMgsChucVu").text("");
         
        }
    });
    $("#phongBan").mouseup(function () {
        var phongBan = $("#phongBan").val();
        if (phongBan == "Chọn phòng ban") {
            $("#ErrorMgsPhongBan").text("Bạn bắt buộc phải chọn trường này!");
            $("#SubmitBtn").prop("disabled", true);
        }
        else {
            $("#SubmitBtn").prop('disabled', false);
            $("#ErrorMgsPhongBan").text("");
        }
    });
//Import Excel==================================================
    $("#ImportExcel").click(function () {
        console.log("bam vao inport");
        $("#imPort").trigger("click");

        $("#imPort").change(function () {
            $("#okImport").trigger("click");
        });
        /*$("#okImport").trigger("click");*/
        
    });
    //Export Excel==================================================
    $("#excelExport").click(function () {
        console.log(searchPhongBan);
        $.ajax({
            type: "post",
            url: "/staff/Export",
            
            success: function () {
                
                window.location = "/staff/Export";
                
            },
            error: function (req, status, error) {
                console.log(error);
                

            }
        });
    });

    //Lấy biểu mẫu ==================================================
    $("#getBieumau").click(function () {
        console.log(searchPhongBan);
        $.ajax({
            type: "post",
            url: "/staff/ExportBieuMau",

            success: function () {

                window.location = "/staff/ExportBieuMau";

            },
            error: function (req, status, error) {
                console.log(error);


            }
        });
    });
});


 


   



                    



