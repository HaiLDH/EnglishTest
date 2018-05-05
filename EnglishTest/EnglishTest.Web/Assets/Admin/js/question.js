$(document).ready(function () {
    loadData();
});



function loadData() {
    $.ajax({
        url: "/AdminQuestion/GetListQuestion",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td rowspan="2" style="width: 10px; text-align:center; vertical-align:middle">' + item.QuestionID + '</td>';
                html += '<td>' + item.Content + '</td>';
                html += '<td>' + item.Level + '</td>';
                html += '<td>' + item.TestKitID + '</td>';
                html += '<td>' + item.CreateBy + '</td>';
                html += '<td>' + formatDate(new Date(parseInt(item.CreateDate.substr(6)))) + '</td>';
                html += '<td>' + item.UpdateBy + '</td>';
                html += '<td>' + formatDate(new Date(parseInt(item.UpdateDate.substr(6)))) + '</td>';
                html += '<td rowspan="2" style="text-align:center; vertical-align:middle"><button style="margin-right: 4px;" class="btn btn-sm btn-primary"><i class="fa fa-pencil-square-o"></i></button><button style="margin-left: 4px;" class="btn btn-sm btn-danger"><i class="fa fa-trash-o"></i></button></td>';
                html += '</tr>';
                html += '<tr>';
                html += '<td>' + "A" + '</td>';
                html += '<td colspan="2">' + "B" + '</td>';
                html += '<td colspan="2">' + "C" + '</td>';
                html += '<td colspan="2">' + "D" + '</td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//Add Data Function
function AddQuestion() {
    var question = {
        QuestionID: 2,
        Content: "Content",
        Level: "Level",
        TestKitID: "TestKitID"
    };
    $.ajax({
        url: "/AdminQuestion/AddQuestion",
        data: JSON.stringify(question),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            alert("Add question complete!!");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}


function formatDate(date) {
    var newdate = new Date(date),
        month = '' + (newdate.getMonth() + 1),
        day = '' + newdate.getDate(),
        year = newdate.getFullYear();

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [day, month, year].join('/');
}