# Marble_Clock

Below program uses stacks and queues to simulate the behavior of the marble clock. Integers are used to represent the marbles (that is, marbles are numbered 1, 2, 3, 4, 5, ...). The initial number of marbles used to fill the reservoir is obtained as user input. The Program determines the number of 12-hour cycles the clock goes through before the marbles in the reservoir are back in their original order (relative to the number of input marbles used to fill the reservoir).

#Logic:
1)In order to write the code we created a queue for the reservoir. The marble clock consists of five shallow trays arranged one above the other. The bottom tray (the fifth tray) serves as a marble reservoir.

2)Every minute, a winding mechanism picks up one marble from the bottom tray, carries it to the top of the clock and drops it into the top tray of the clock. As a tray fills up marbles fall through lower level trays as described below. 

3)The current state of the marbles in the upper four trays tells the current time. 

4)Each marble in the top tray (first tray) represents a single minute. This first tray has room for four marbles. These marbles all enter from the same end and roll down to the other end of the tray. When the first tray is full, the next marble drops to the second tray (the second tray represents 5 minute intervals) and in the process trips a latch that tilts the top tray causing the marbles there to exit the same end that they entered and return to the end of the line in the reservoir (bottom) tray. 

5)The second tray holds a maximum of two marbles, and when a third marble arrives, it drops to the next tray (representing 15 minute intervals). Then, the second tray is emptied in a manner analogous to the first. 

6)Finally, the third (15-minute) tray can hold three marbles and a fourth marble drops into the hour’s tray (fourth tray), causing the 15 minute tray to be emptied back into the reservoir. The hour’s tray holds 11 marbles, when a twelfth marble arrives it trips the tray which empties into the reservoir. The tripping marble then also drops into the reservoir, completing the cycle. Thus, a complete cycle is 12 hours.

