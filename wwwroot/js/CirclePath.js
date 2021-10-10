var xCoords = [];
var yCoords = [];

$(document).ready(function () {
    $('.line-area').click(function (e) {
        var xCoord = 0;
        var yCoord = 0;
        xCoord = e.clientX;
        yCoord = e.clientY;

        var circle = document.createElement("div");
        circle.classList.add("circle");
        circle.style.borderRadius = "50%"; //Make div a circle
        circle.style.height = "25px";
        circle.style.width = "25px";
        circle.style.backgroundColor = "black";
        circle.style.position = "absolute";

        var startPositionX = xCoord - 12.5 - 384; // Circles radius is 12.5, changing start position allows circle center to be at the click
        var startPositionY = yCoord - 12.5 - 184;


        circle.style.left = "" + startPositionX + "px";
        circle.style.top = "" + startPositionY + "px";

        $(".line-area").append(circle);

        xCoords.push(xCoord);
        yCoords.push(yCoord);

        /*alert("" + xCoord + " " + yCoord);*/
    });

    $('#draw-btn').click(function (e) {
        var tempXCoords = xCoords;
        var tempYCoords = yCoords;
        var nextIndexToCheck = -1; // initial value doesn't matter
        // next index to check is the index that the
        // line ends at so it makes a continuous line
        for (i = 0; i < xCoords.length; i++) { // 0(N)  loop over coordinate array n times
            var xCoord = -1;
            var yCoord = -1;

            if (i == 0) {
                xCoord = xCoords[i];
                yCoord = yCoords[i];
            } else {
                xCoord = xCoords[nextIndexToCheck];
                yCoord = yCoords[nextIndexToCheck];
            }

            var shortestLengthATM = -1;
            var shortestLengthIndexATM = -1; // initial value doesn't matter
            
            for (y = 0; y < tempXCoords.length; y++) { // 0(N^2)
                if (i == y) {
                    continue;
                } else if (tempXCoords[y] == -1) {
                    continue;
                }

                var tempX = xCoords[y];
                var tempY = yCoords[y];
                var hypotenuse = Math.sqrt(Math.abs(tempX - xCoord) ^ 2 + Math.abs(tempY - yCoord) ^ 2);

                if (y == 1) {
                    shortestLengthIndexATM = 1;
                    shortestLengthATM = hypotenuse;
                } else {
                    if (hypotenuse < shortestLengthATM) {
                        shortestLengthATM = hypotenuse;
                        shortestLengthIndexATM = y;
                    }
                }
            }
            createLine(xCoord, tempXCoords[shortestLengthIndexATM], yCoord, tempYCoords[shortestLengthIndexATM]);
            if (i != 0) {
                tempXCoords[shortestLengthIndexATM] = -1;
                tempYCoords[shortestLengthIndexATM] = -1;
            }
            nextIndexToCheck = shortestLengthIndexATM;
        }
    });

    $('.clear-btn').on('click', function () {
        $('.line-area').empty();
        xCoords = [];
        yCoords = [];
    })

    function createLine(x1, x2, y1, y2) {
        var distance = Math.sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));

        var xMid = (x1 + x2) / 2;
        var yMid = (y1 + y2) / 2;

        var slopeInRadians = Math.atan2(y1 - y2, x1 - x2);
        var slopeInDegrees = (slopeInRadians * 180) / Math.PI;

        var div = '<div class="line" style=" ';
        div += 'width: ' + distance + 'px; ';
        div += 'top: ' + yMid + 'px; ';
        div += 'left:' + xMid - (distance / 2) + 'px; ';
        div += 'transform: rotate(' + slopeInDegrees + 'deg); "></div>';


        $('.line-area').append(div);
        //var line = document.createElement('div');
        //document.getElementsByClassName('line-area')[0].appendChild(line);
        //line.className = "line";
        //line.style.width = distance;
        //line.style.top = yMid;
        //line.style.left = xMid - (distance / 2);
        //line.style.transform = "rotate(" + slopeInDegrees + "deg)";

        
    }
});