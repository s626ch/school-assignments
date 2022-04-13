var secMin = 60;
var minHr = 60;
var hrDay = 24;
var dayYr = 365;

var secHr = secMin * minHr;
document.write("Number of sec in an hr is " + secHr);
document.write("<br/>");

var secDay = secHr * hrDay;
document.write("number sec in day " + secDay);
document.write("<br/>");

var secYr = secDay * dayYr;
document.write("number of sec in year " + secYr);
document.write("<br/><br/>");
document.write("created by gage g.");

document.write("<h1>part 2 of assgnmt</h1>");

var numApl = 10;
for (let i = 0; i < 6; i++) {
    document.write("num of apples "+numApl+"<br/>");
    numApl++;
}

document.write("<br/><br/>");

var numNinj = 100;
for (let i = 0; i < 5; i++) {
    document.write("num of ninjas "+numNinj+"<br/>");
    --numNinj;
}

document.write("created by gage g.");