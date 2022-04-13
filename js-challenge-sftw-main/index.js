// ANS 1: 6
// ANS 2: 145
// ANS 3: 36
// ANS 4: 8
// 2 questions need to be switch statements
// 2 need to be if else
// set bg of correct to green and incorr to red with .correct and .incorrect

async function subAnsw() {
    var answ1 = document.getElementById("q1").value;
    var answ2 = document.getElementById("q2").value;
    var answ3 = document.getElementById("q3").value;
    var answ4 = document.getElementById("q4").value;
    // answer 1 -------------------------------------------------------------------------------------------------
    switch (answ1) {
        case "6":
            document.getElementById("div2").classList.add("correct");
            if (document.getElementById("div2").classList.contains("incorrect") === true)  {
                document.getElementById("div2").classList.remove("incorrect");
            } else {
                break;
            }
            break;
        default:
            document.getElementById("div2").classList.add("incorrect");
            if (document.getElementById("div2").classList.contains("correct") === true)  {
                document.getElementById("div2").classList.remove("correct");
            } else {
                break;
            }
            break;
    }
    // answer 2 -------------------------------------------------------------------------------------------------
    switch (answ2) {
        case "145":
            document.getElementById("div3").classList.add("correct");
            if (document.getElementById("div3").classList.contains("incorrect") === true)  {
                document.getElementById("div3").classList.remove("incorrect");
            } else {
                break;
            }
            break;
        default:
            document.getElementById("div3").classList.add("incorrect");
            if (document.getElementById("div3").classList.contains("correct") === true)  {
                document.getElementById("div3").classList.remove("correct");
            } else {
                break;
            }
            break;
    }
    // answer 3 -------------------------------------------------------------------------------------------------
    if (answ3 === "36") {
        document.getElementById("div4").classList.add("correct");
        if (document.getElementById("div4").classList.contains("incorrect") === true)  {
           document.getElementById("div4").classList.remove("incorrect");
        } 
    } else {
        document.getElementById("div4").classList.add("incorrect");
        if (document.getElementById("div4").classList.contains("correct") === true)  {
           document.getElementById("div4").classList.remove("correct");
        } 
    }
    // answer 4 -------------------------------------------------------------------------------------------------
    if (answ4 === "8") {
        document.getElementById("div5").classList.add("correct");
        if (document.getElementById("div5").classList.contains("incorrect") === true)  {
           document.getElementById("div5").classList.remove("incorrect");
        }
    } else {
        document.getElementById("div5").classList.add("incorrect");
        if (document.getElementById("div5").classList.contains("correct") === true)  {
           document.getElementById("div5").classList.remove("correct");
        } 
    }
}