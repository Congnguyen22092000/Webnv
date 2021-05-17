$(document).ready(function () {
    var coutOld = $("#coutOld").val();
    var coutNew = $("#coutNew").val();
    var baoLoi = $("#BaoLoi").val();
    /*console.log(baoLoi);
    console.log(coutNew);
    console.log(coutOld);*/
    /*alert('Đã thêm: '+ coutNew + ' nhân viên và sửa: ' + coutOld+' nhân viên!');*/
    /*alert('đã đi qua import');*/
    $("#imPort").trigger("click");
    $('#nextImport').click(function () {
    window.location = "/staff/Index";
        
    });
    
});
