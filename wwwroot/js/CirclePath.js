var xCoords = [];
var yCoords = [];

$(document).ready(function () {
    createCircle(400, 200);
    createCircle(500, 200);
    createLine(xCoords[0], xCoords[1], yCoords[0], yCoords[1]);

    $('.line-area').click(function (e) {
        var xCoord = 0;
        var yCoord = 0;
        xCoord = e.clientX;
        yCoord = e.clientY;

        createCircle(xCoord, yCoord);
    });

    $('#draw-btn').click(function (e) {
        $(".line").remove();

        var tempXCoords = xCoords;
        var tempYCoords = yCoords;
        var nextIndexToCheck = -1; // initial value doesn't matter
        // next index to check is the index that the
        // line ends at so it makes a continuous line
        debugger;
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
        x1 += 12.5;
        x2 += 12.5;
        y1 += 12.5;
        y2 += 12.5;
 
        var length = Math.sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        // center
        var cx = ((x1 + x2) / 2) - (length / 2);
        var cy = ((y1 + y2) / 2) - (5 / 2);
        // angle
        var angle = Math.atan2((y1 - y2), (x1 - x2)) * (180 / Math.PI);
        // make hr
        var htmlLine = "<div class='line' style='padding:0px; margin:0px; height:" + 5 + "px; background-color: black; line-height:1px; position:absolute; left:" + cx + "px; top:" + cy + "px; width:" + length + "px; -moz-transform:rotate(" + angle + "deg); -webkit-transform:rotate(" + angle + "deg); -o-transform:rotate(" + angle + "deg); -ms-transform:rotate(" + angle + "deg); transform:rotate(" + angle + "deg);' />";
        $('.line-area').append(htmlLine)
    }

    function createCircle(xCoord, yCoord) {
        var circle = document.createElement("div");
        circle.classList.add("circle");
        circle.style.borderRadius = "50%"; //Make div a circle
        circle.style.height = "25px";
        circle.style.width = "25px";
        circle.style.backgroundColor = "black";
        circle.style.position = "absolute";

        var finalX = xCoord - 12.5 - 384;
        var finalY = yCoord - 12.5 - 184

        var startPositionX = finalX; // Circles radius is 12.5, changing start position allows circle center to be at the click
        var startPositionY = finalY;


        circle.style.left = "" + startPositionX + "px";
        circle.style.top = "" + startPositionY + "px";

        $(".line-area").append(circle);

        xCoords.push(finalX);
        yCoords.push(finalY);

       /* alert("" + xCoord + " " + yCoord);*/
    }
});