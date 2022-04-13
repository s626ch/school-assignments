function calculateBmiImp() {
    // variables
    var weightAmnt = document.getElementById("weightInput").value;
    var heightAmnt = document.getElementById("heightInput").value;
    // originally had these wrapped in parseInt(x, 10); not needed now though, especially if dealing with exact decimals.
    // only thing that needs rounded is the final number lmao
    var weightNum = weightAmnt;
    console.log(weightNum);
    var heightNum = heightAmnt;
    console.log(heightNum); 
    var bmi = weightNum / Math.pow(heightNum, 2) * 703;
    console.log(bmi);
    
    if (bmi > 0 && bmi < 19) {
        var resultCDC = "; Underweight.";
    } else if (bmi > 18 && bmi < 26) {
        var resultCDC = "; Healthy!";
    } else if (bmi > 25 && bmi < 30) {
        var resultCDC = "; Overweight.";
    } else if (bmi > 29 && bmi < 40) {
        var resultCDC = "; Obese.";
    } else if (bmi > 39) {
        var resultCDC = "; Extremely obese.";
    }

    console.log(resultCDC);
    document.getElementById("calcResult").innerHTML = "Result: " + parseInt(bmi) + resultCDC;
}

function popitup(url,windowName) {
    newwindow=window.open(url,windowName,'height=432,width=602');
    if (window.focus) {newwindow.focus()}
    return false;
}

function changeModeMetric() {
    // this is to change it to metric WOAWOOAWOWAOAOOA
    document.getElementById("weightInput").placeholder = "Weight, kilograms."
    document.getElementById("weightInput").value = ""
    document.getElementById("heightInput").placeholder = "Height, metres."
    document.getElementById("heightInput").value = ""
    document.getElementById("calcButton").setAttribute('onclick','calculateBmiMet()');
    // change button to go back
    document.getElementById("changeModeButton").setAttribute('onclick','changeModeImp()');
    document.getElementById("changeModeButton").innerHTML = "Change to Imperial inputs."
}

function changeModeImp() {
    // this is to change it to metric WOAWOOAWOWAOAOOA
    document.getElementById("weightInput").placeholder = "Weight, pounds."
    document.getElementById("weightInput").value = ""
    document.getElementById("heightInput").placeholder = "Height, inches."
    document.getElementById("heightInput").value = ""
    document.getElementById("calcButton").setAttribute('onclick','calculateBmiImp()');
    // change button to go back
    document.getElementById("changeModeButton").setAttribute('onclick','changeModeMetric()');
    document.getElementById("changeModeButton").innerHTML = "Change to Metric inputs."
}

function calculateBmiMet() {
    // variables
    var weightAmnt = document.getElementById("weightInput").value;
    var heightAmnt = document.getElementById("heightInput").value;
    var weightNum = weightAmnt;
    console.log(weightNum);
    var heightNum = heightAmnt;
    console.log(heightNum); 
    var bmi = weightNum / Math.pow(heightNum, 2);
    console.log(bmi);
    
    if (bmi > 0 && bmi < 19) {
        var resultCDC = "; Underweight.";
    } else if (bmi > 18 && bmi < 26) {
        var resultCDC = "; Healthy!";
    } else if (bmi > 25 && bmi < 30) {
        var resultCDC = "; Overweight.";
    } else if (bmi > 29 && bmi < 40) {
        var resultCDC = "; Obese.";
    } else if (bmi > 39) {
        var resultCDC = "; Extremely obese.";
    }

    console.log(resultCDC);
    document.getElementById("calcResult").innerHTML = "Result: " + parseInt(bmi) + resultCDC;
}