function getpartialData() {
    $.get("http://localhost:56237/Partial/Partial2", function (data) {
        $('#divpartial').html(data);
    });
}
function postStudent() {
    var input = $('#studentform').serialize();
    var input2 = {
        ID: 10,
        Name:'rama1'
    }
    $.post("http://localhost:56237/student/CreateNew", input2, function (data) {
        console.log(data);
    });
}