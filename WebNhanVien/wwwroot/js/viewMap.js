$(document).ready(function () {
    console.log("cai nay chi ton tai 1 lan" + $("#check").val());
    if ($("#check").val() == 0) {
        $("#check").val(1);
        

        var dem = $("#dem").val();
        $.ajax({
            type: "get",
            url: "/staff/getListNV",

            dataType: "json",
            success: function (data) {
                console.log(data);
                console.log("phan tu thu 1: " + data[1].maNhanVien);

                for (var i = 0; i < dem; i++) {
                    //Get value=============================================================
                    var maNhanVien = data[i].maNhanVien;
                    var hoTen = data[i].hoTen;

                    var chucVu = data[i].chucVu;
                    var phongBan = data[i].ten_phong_ban;
                    var temLon = data[i].lon;
                    var content = temLon.toString().replace(',', '.');
                    temLon = parseFloat(content);
                    var temLat = data[i].lat;
                    var content2 = temLat.toString().replace(',', '.');
                    temLat = parseFloat(content2);

                    //Xử lý
                    var marker = L.marker([temLon, temLat]).addTo(mymap);
                    marker.bindPopup("<b>" + maNhanVien + "</b><br>" + hoTen + "<br>Chức Vụ: " + chucVu + "<br>Phòng Ban: " + phongBan);
                    var popup = L.popup()
                        .setLatLng([temLon, temLat])
                        /*.setContent()
                        .openOn(mymap);*/
                    
                }

            },
            error: function (req, status, error) {
                console.log(error);

            }


        });

        //Sự kiện tìm kiếm map
        $("#btnSearch").click(function () {
            $("#tableSearch").remove();
            var key = $("#SearchBox").val();
            console.log("key get ra:" + key);
            $("#tableView").prop("hidden", false);

            $.ajax({
                type: "Post",
                url: "/staff/GetSearchMap",
                data: { key: key },
                dataType: "text",
                success: function (data) {

                    $("#tableView").html(data);

                },
                error: function (req, status, error) {
                    console.log(error);

                }
            });
        });

        //Sự kiện xóa map
        $("#btnDelete").click(function () {
            $("#SearchBox").val("");
            console.log("da bam vao xoa");
            $("#tableSearch").remove();
            $("#tableView").prop('hidden', true);
        });

       
       
        
        
    }
    
    //click vào tìm kiếm
    $('#tableSearch tr').click(function () {

        $("#tableSearch").remove();
        $("#tableView").prop('hidden', true);
        var temp = $(this).find("a").attr("id");
        $("#btnDelete").trigger("click");

        $.ajax({
            type: "Post",
            url: "/staff/searchLonLat",
            data: { key: temp },
            dataType: "json",
            success: function (data) {
                console.log(data);
                var maNhanVien = data[0].maNhanVien;
                var hoTen = data[0].hoTen;

                var chucVu = data[0].chucVu;
                var phongBan = data[0].ten_phong_ban;
                var tempLon = data[0].lon;
                var tempLat = data[0].lat;

                var marker = L.marker([tempLon, tempLat]).addTo(mymap);
                marker.bindPopup("<b>" + maNhanVien + "</b><br>" + hoTen + "<br>Chức Vụ: " + chucVu + "<br>Phòng Ban: " + phongBan).openPopup();
                var popup = L.popup()
                    .setLatLng([tempLon, tempLat])

                mymap.setView([tempLon, tempLat], 12);


                
                
            },
            error: function (req, status, error) {
                console.log(error);

            }
        });

    });
    
    $('#SearchBox').keypress(function (event) {
        var keycode = (event.keyCode ? event.keyCode : event.which);
        if (keycode == '13') {
            $("#tableSearch").remove();
            var key = $("#SearchBox").val();
            console.log("key get ra:" + key);
            $("#tableView").prop("hidden", false);

            $.ajax({
                type: "Post",
                url: "/staff/GetSearchMap",
                data: { key: key },
                dataType: "text",
                success: function (data) {

                    $("#tableView").html(data);

                },
                error: function (req, status, error) {
                    console.log(error);

                }
            });
        }
    });
   
    
});
