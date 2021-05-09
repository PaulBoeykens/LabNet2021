$(document).ready(function () {
    $("#form").validate({
        rules: {
            Id: {
                required: true,
                text: false,
                number: true,
                minlength: 5,
                maxlength: 20
            },
            Description: {
                required: true,
                number: true,
                text: true,
                minlength: 3
                
            },
            RegionId: {
                required: true,
                number: true,
                text: false,
                maxlength: 1,
                minlength: 1
            }
        },
        messages: {
            Id: {
                minlength: "ID should be at least 5 numbers",
                maxlength: "the ID can't have more than 20 numbers"
            },
            Description: {
                required: "Please enter your description",
                minlength: "Description should be at least 3 characters"
            },
            RegionId: {
                minlength: "The description must be only 1 character",
                maxlength: "The description must be only 1 character",
                number: "Please enter your weight as a numerical value"
            }
        }
    });
});


        
