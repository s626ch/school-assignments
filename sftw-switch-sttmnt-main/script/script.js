var subject, totalQuestions, numCorrect, percentScore;

function testResults() {
    subject = document.getElementById("subject").value;
    totalQuestions = document.getElementById("numberOfQuestions").value;
    numCorrect = document.getElementById("numberCorrect").value;
    percentScore = numCorrect/totalQuestions*100;
    percentScore = percentScore.toFixed(2);
    console.log(subject + '\n\n' + totalQuestions + '\n\n' + numCorrect + '\n\n' + percentScore);
    //grades
    var gradA = 90;
    var gradB = 80;
    var gradC = 70;
    var gradD = 60;
    switch(true){
        case percentScore >= gradA:
            document.getElementById("testResults").innerHTML = "A";
            document.getElementById("testMessage").innerHTML = `Excellent job, you got ${percentScore}% correct!\nThat's an 'A' for Awesome.`;
            break;
        case percentScore >= gradB:
            document.getElementById("testResults").innerHTML = "B";
            document.getElementById("testMessage").innerHTML = `Good job, you got ${percentScore}% correct!\nThat's a 'B' for Ballin.`;
            break;
        case percentScore >= gradC:
            document.getElementById("testResults").innerHTML = "C";
            document.getElementById("testMessage").innerHTML = `Nice job, you got ${percentScore}% correct!\nThat's a 'C' for Cool, but needs improvement.`;
            break;
        case percentScore >= gradD:
            document.getElementById("testResults").innerHTML = "D";
            document.getElementById("testMessage").innerHTML = `Decent job, you got ${percentScore}% correct.\nThat's a 'D' for Didn't fail.`;
            break;
        case percentScore < gradD:
            document.getElementById("testResults").innerHTML = "F";
            document.getElementById("testMessage").innerHTML = `Well, you tried. You got ${percentScore}% correct.\nThat's an 'F' for Forgot to study.`;
            break;
        default:
            console.log("default");
    }
}

function clearResults() {
    document.getElementById('testDate').value = '';
    document.getElementById('subject').value = '';
    document.getElementById('numberOfQuestions').value = '';
    document.getElementById('numberCorrect').value = '';
}
  
//ToDo - New Function
// Create a function called clearResults() that resets the forms values. 
