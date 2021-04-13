


//Sự kiện search======================================================
$(document).ready(function () {
    $("input[name='key']").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#StaffTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
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

//sự kiện sửa nhân viên===============================================================
    $(".click").click(function (event) {
        event.preventDefault();
        var temp = $(this).attr("id");
        temp = temp.toString().substr(4, 1);
        console.log(temp);



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
    
});


    // Get the modal
 


    var spanEdit = document.getElementById("closeBtnEdit");






                        spanEdit.onclick = function () {
        modal.style.display = "none";
                        }



                    



