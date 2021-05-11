


//Sự kiện search======================================================
$(document).ready(function () {
   
    
    //Sự kiện delete=====================================================


    $(".delBtn").click(function () {
        
        
        var MaNhanVien = $(this).attr("id");
        $("#NV-" + MaNhanVien).modal('toggle');
        $(".modal-backdrop").remove();
        console.log(MaNhanVien);
        var pageIndex = parseInt($(".active").parent().attr("id").substring(2));
        $.ajax({
            type: "Post",
            url: "/staff/delete",
            data: { MaNhanVien: MaNhanVien },
            dataType: "json",
            success: function (json) {
                var delCurrentPage = "p-" + pageIndex.toString();
                $("#" + MaNhanVien).closest("tr").remove();
                $("#pagenav").empty();
                $.ajax({
                    type: "Post",
                    url: "/staff/pagenav",
                    data: { currentPage: delCurrentPage, keyBox: "",keyPhongBan: "Tất Cả" },
                    dataType: "text",
                    success: function (data) {
                        $("#pagenav").html(data);
                    },
                    error: function (req, status, error) {
                        console.log(error);

                    }
                });

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
      
        

        $('#closeBtnEdit_' + temp).click(function (event) {
           
            $("#editNV-" + temp).modal("hide");
            $(".modal-backdrop").remove();
        });

        
        $('#EditBtn-'+temp).click(function () {
            console.log("Appect submit");
            

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
       

    });
    var modal = document.getElementById("myModal");


    var btn = document.getElementById("myBtn");


    var span = document.getElementsByClassName("closeBtnCreate")[0];




    btn.onclick = function () {
        modal.style.display = "block";
    }


    span.onclick = function () {
        
        /*$(".modal-backdrop").remove();*/
        modal.style.display = "none";
        
    }


    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }



});


    // Get the modal











