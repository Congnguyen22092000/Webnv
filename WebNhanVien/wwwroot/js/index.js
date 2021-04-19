


//Sự kiện search======================================================
$(document).ready(function () {
    /*$("input[name='key']").on("keyup",function () {
        var value = $(this).val().toLowerCase();
        $("#StaffTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });*/


    $("#SearchBox").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        if (value == "") {
            /*$("#pagenav").show();*/
            $(".active").trigger("click");
        }
        else {
            /*$("#pagenav").hide();*/
            $.ajax({
                type: "Post",
                url: "/staff/search",
                data: { key: value },
                dataType: "text",
                success: function (data) {
                    console.log(value);
                    $("#StaffTable").html(data);
                    console.log(data);

                },
                error: function (req, status, error) {
                    console.log(error);

                }
            });
        }

    });
//Sự kiện delete=====================================================
    $(".delBtn").click(function (event) {
        event.preventDefault();
        var maNhanVien = $(this).attr("id");

        $.ajax({
            type: "Post",
            url: "/staff/delete",
            data: { maNhanVien: maNhanVien },
            dataType: "json",
            success: function (json) {
                $("#Huy-" + maNhanVien).trigger("click");
                $("#" + maNhanVien).closest("tr").remove();
            },     
            error: function (req, status, error) {
                console.log(error);

            }
        });

    });
//sự kiện thêm nhân viên===============================================
    $("#hoTen").blur(function () {
       
        var maNhanVien = $("#maNhanVien").val();
        var hoTen = $("#hoTen").val();
        var ngaySinh = $("#ngaySinh").val();
        var soDT = $("#soDT").val();

        var chucVu = $("#chucVu").val();

        $.ajax({
            type: "Post",
            url: "/staff/IsDuplicatedStaff",
            data: { maNhanVien: maNhanVien, hoTen: hoTen, ngaySinh: ngaySinh, soDT: soDT, chucVu: chucVu },
            dataType: "json",
            success: function (json) {
                var a = json;
                if (a == true) {
                    $("#SubmitBtn").prop("disabled", true);
                    $("#ErrorMgs").text("Nhân Viên Đã Tồn Tại");
                    $("#hoTen").css("border-color", "red");
                    $("#ngaySinh").css("border-color", "red");
                }
                if (a == false) {
                    $("#SubmitBtn").prop('disabled', false);
                    $("#ErrorMgs").text("");
                    $("#hoTen").css("border-color", "#ced4da");
                    $("#ngaySinh").css("border-color", "#eff1f3");
                }
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });
    });
    $("#ngaySinh").blur(function () {
        
        var maNhanVien = $("#maNhanVien").val();
        var hoTen = $("#hoTen").val();
        var ngaySinh = $("#ngaySinh").val();
        var soDT = $("#soDT").val();

        var chucVu = $("#chucVu").val();

        $.ajax({
            type: "Post",
            url: "/staff/IsDuplicatedStaff",
            data: { maNhanVien: maNhanVien, hoTen: hoTen, ngaySinh: ngaySinh, soDT: soDT, chucVu: chucVu },
            dataType: "json",
            success: function (json) {
                var a = json;
                if (a == true) {
                    $("#SubmitBtn").prop("disabled", true);
                    $("#ErrorMgs").text("Nhân Viên Đã Tồn Tại");
                    $("#hoTen").css("border-color", "red");
                    $("#ngaySinh").css("border-color", "red");
                }
                if (a == false) {
                    $("#SubmitBtn").prop('disabled', false);
                    $("#CreateForm").unbind(event)
                    $("#ErrorMgs").text("");
                    $("#hoTen").css("border-color", "ced4da");
                    $("#ngaySinh").css("border-color", "ced4da");
                }
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });
    });
//Sự kiện thêm=======================================================================
   /* $(".btnCreate").click(function (even) {
        event.preventDefault();
        console.log("oke toi roi");
        $(".modal").modal("show");
        

        $('#closeBtnCreate').click(function (event) {
            console.log("checkkkkkkk");
            $("#myModal").modal("hide");
        });
    });*/
//sự kiện sửa nhân viên===============================================================
    $(".click").click(function (event) {

        event.preventDefault();
        var temp = $(this).attr("id");
        temp = temp.toString().substr(4, 1);
        console.log(temp);

        /*var spanEdit = document.getElementById("closeBtnEdit_" + temp);
        var modalEdit = document.getElementsByClassName("modalEdit_" +temp);*/
        $('#closeBtnEdit_' + temp).click(function (event) {
            console.log("checkkkkkkk");
            $("#editNV-" + temp).modal("hide");
        });
        

        

        $('#hoTen-' + temp).blur(function () {

      
            var maNhanVien = $('#maNV-' + temp).val();
            var hoTen = $('#hoTen-' + temp).val();
            var ngaySinh = $('#ngaySinh-' + temp).val();
            var soDT = $('#soDT-' + temp).val();

            var chucVu = $('#chucVu-' + temp).val();

            $.ajax({
                type: "Post",
                url: "/staff/IsDuplicatedStaff",
                data: { maNhanVien: maNhanVien, hoTen: hoTen, ngaySinh: ngaySinh, soDT: soDT, chucVu: chucVu },
                dataType: "json",
                success: function (json) {
                    var a = json;
                    if (a == true) {
                        $("#EditBtn-" + temp).prop("disabled", true);
                        $('#errormesageHoTen-' + temp).text("Nhân Viên Đã Tồn Tại");
                        $('#hoTen-' + temp).css("border-color", "red");
                        $('#ngaySinh-' + temp).css("border-color", "red");
                    }
                    if (a == false) {
                        $("#EditBtn-" + temp).prop('disabled', false);
                        $('#errormesageHoTen-' + temp).text("");
                        $('#hoTen-' + temp).css("border-color", "#ced4da");
                        $('#ngaySinh-' + temp).css("border-color", "#eff1f3");
                    }
                },
                error: function (req, status, error) {
                    console.log(error);

                }
            });
        });
        $('#ngaySinh-' + temp).blur(function () {

            $('#test').id;


            var maNhanVien = $('#maNV-' + temp).val();
            var hoTen = $('#hoTen-' + temp).val();
            var ngaySinh = $('#ngaySinh-' + temp).val();
            var soDT = $('#soDT-' + temp).val();

            var chucVu = $('#chucVu-' + temp).val();    

            $.ajax({
                type: "Post",
                url: "/staff/IsDuplicatedStaff",
                data: { maNhanVien: maNhanVien, hoTen: hoTen, ngaySinh: ngaySinh, soDT: soDT, chucVu: chucVu },
                dataType: "json",
                success: function (json) {
                    var a = json;
                    if (a == true) {
                        $("#EditBtn-" + temp).prop("disabled", true);
                        $('#errormesageHoTen-'+ temp).text("Nhân Viên Đã Tồn Tại");
                        $('#hoTen-' + temp).css("border-color", "red");
                        $('#ngaySinh-' + temp).css("border-color", "red");
                    }
                    if (a == false) {
                        $("#EditBtn-" + temp).prop('disabled', false);
                        $('#errormesageHoTen-' + temp).text("");
                        $('#hoTen-' + temp).css("border-color", "#ced4da");
                        $('#ngaySinh-' + temp).css("border-color", "#eff1f3");
                    }
                },
                error: function (req, status, error) {
                    console.log(error);

                }
            });
        });
        
    });
    var modal = document.getElementById("myModal");


    var btn = document.getElementById("myBtn");


    var span = document.getElementsByClassName("closeBtnCreate")[0];




    btn.onclick = function () {
        modal.style.display = "block";
    }


    span.onclick = function () {
        modal.style.display = "none";
    }


    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
   
});


    // Get the modal
 


   



                    



