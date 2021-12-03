﻿//Share Job Post
function ShareJobPost() {
    ComingSoon();
}

//Start informal voting process, only job doer is authorized for this action
function StartInformalVoting(JobId) {
    $.confirm({
        title: 'Confirmation',
        content: '<b>Are you confirming that you submitted a valid evidence for job completion and start informal voting process ?</b>' +

            '<div class="form-check m-2"><input class="form-check-input" type="checkbox" value="" id="checkConfirm1"><label class="form-check-label text-justify" for="flexCheckDefault">I hereby declare that all results, work product, etc. associated with my bid and associated work product will be made available under an open-source license. I acknowledge that I am legally responsible to ensure that all parts of this project are open-source. </label></div>'
            + '<div class="form-check m-2"><input class="form-check-input" type="checkbox" value="" id="checkConfirm2"><label class="form-check-label text-justify" for="flexCheckDefault">     I hereby declare that my bid and associated work product will benefit decentralization and open-source projects generally, pursuant to the mission statement of OSSA, which is to support open source and transparent scientific research of emerging technologies for community building by way of submitting grants to developers and scientists in Switzerland and abroad. </label></div>'
            + '<div class="form-check m-2"><input class="form-check-input" type="checkbox" value="" id="checkConfirm3"><label class="form-check-label text-justify" for="flexCheckDefault">            I hereby declare that my bid and associated work product is in line with international transparency standards; will be published on Github under the CRDAO repo, and my team and I have sufficient qualifications, experience and capacity to actually finish my bid and associated work product. </label></div>'
            + '<div class="form-check m-2"><input class="form-check-input" type="checkbox" value="" id="checkConfirm4"><label class="form-check-label text-justify" for="flexCheckDefault">    I hereby declare that I have not built tools and do not intend to build tools to attack the CRDAO and OSSA. </label></div>'
            + '<div class="form-check m-2"><input class="form-check-input" type="checkbox" value="" id="checkConfirm5"><label class="form-check-label text-justify" for="flexCheckDefault">   I hereby declare that I have not previously failed to fulfill my contractual obligations under an earlier bid and associated work product between myself and the CRDAO and OSSA.</label></div>'
        ,
        columnClass: 'col-md-8 col-md-offset-2',
        buttons: {
            cancel: {
                text: 'Cancel'
            },
            confirm: {
                text: 'Continue',
                btnClass: 'btn btn-primary',
                action: function () {

                    var confirmationControl = true;

                    for (var i = 1; i < 6; i++) {
                        var checked = $("#checkConfirm" + i).is(':checked');

                        if (checked == false) {
                            confirmationControl = false;
                        }
                    }

                    if (confirmationControl == false) {
                        toastr.warning("You must confirm agreements before starting informal voting process.");

                        return false;
                    }

                    $.ajax({
                        url: "../StartInformalVoting/" + JobId,
                        type: "GET",
                        dataType: 'json',
                        success: function (result) {
                            if (result.success) {
                                toastr.success(result.message);
                                setTimeout(function () { window.location.reload() }, 5000)
                            }
                            else {
                                toastr.warning(result.message);
                            }
                        },
                        failure: function (response) {
                            toastr.warning("Connection error");
                        },
                        error: function (response) {
                            toastr.error("Unexpected error");
                        }
                    });

                }

            }
        }
    });
}

function KYCModal() {
    $("#KYCModal").modal("toggle");
}

selectedJobId = 0;
function PayDosFeeModal(JobId) {
    $("#DosFeeModal").modal("toggle");
    selectedJobId = JobId;
}

function SubmitKYC() {
    $.ajax({
        url: "../SubmitKYC",
        type: "GET",
        dataType: 'json',
        success: function (result) {
            if (result.success) {
                toastr.success(result.message);
                $("#KYCModal").modal("toggle");
                setTimeout(function () { window.location.reload() }, 5000)
            }
            else {
                toastr.warning(result.message);
            }
        },
        failure: function (response) {
            toastr.warning("Connection error");
        },
        error: function (response) {
            toastr.error("Unexpected error");
        }
    });
}

function PayDosFee() {
    $.ajax({
        url: "../PayDosFee/" + selectedJobId,
        type: "GET",
        dataType: 'json',
        success: function (result) {
            if (result.success) {
                toastr.success(result.message);
                $("#DosFeeModal").modal("toggle");
                setTimeout(function () { window.location.reload() }, 5000)
            }
            else {
                toastr.warning(result.message);
            }
        },
        failure: function (response) {
            toastr.warning("Connection error");
        },
        error: function (response) {
            toastr.error("Unexpected error");
        }
    });
}

function GoToJobDetail(pageurl, jobid) {
    if (pageurl.indexOf("Job-Detail") == -1) {
        window.location.href = '../Job-Detail/' + jobid;
    }
}

//Features which are not available at the moment should call this methods
function ComingSoon() {
    toastr.warning("This feature will be available in the next version.");
}


$('input.number').on("input", function (e) {
    $(this).val($(this).val().replace(/[^0-9\.]/g, ''));
})

