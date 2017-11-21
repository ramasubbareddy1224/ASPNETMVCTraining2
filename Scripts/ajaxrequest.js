function getPartailTableData() {
    $.get("http://localhost:56237/actionresult/GetTableData", function (data) {
        $('#divpdata').html(data);
    })
}
function postStudentData() {
    //var input = {
    //    Name: $('#Name').val(),
    //    Email: $('#Email').val(),
    //    Phone: $('#Phone').val()
    //};

    var input = $('#studentform').serialize();
    $.post("http://localhost:56237/student/CreateNew", input, function (data) {

    })
}
