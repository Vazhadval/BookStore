
var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $("#tblData").DataTable({

        "ajax": {
            "url": "/Admin/CoverType/GetAll"
        },
        "columns": [
            { "data": "name", "width": "70%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href="/Admin/CoverType/Upsert/${data}" class="btn btn-success" style="cursor:pointer;"><i class="fas fa-edit"></i></a>
                            <a onclick=Delete("/Admin/CoverType/Delete/${data}") class="btn btn-danger" style="cursor:pointer;"><i class="fas fa-trash"></i></a
                        </div>
                    `;
                }, "width": "30%"
            }
        ],
        createdRow: function (row) {

            $(row).addClass('bg-dark');
        }

    });
}

function Delete(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "You will not be able to restore the data!",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({

                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}