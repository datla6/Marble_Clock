open System.Collections.Generic
open System.IO
open System
//The four trays of time
let tray_1= new Stack<int>()
let tray_5= new Stack<int>()
let tray_15=new Stack<int>()
let tray_60=new Stack<int>()
//Reservoir
let reservoir=new Queue<int>()
let mutable reservoir1=new Queue<int>()

let mutable cycle_12=0
let mutable min_1 =0
let mutable min_5 =0
let mutable min_15 =0
let mutable min_60 =0
let marbleclock () = 
    try  
        printfn "MARBLE CLOCK\n"           
        printfn "Enter a value greater than 20 for number of marbles in the reservoir:"
        let marbleno = int32(Console.ReadLine())      
        if  marbleno<21
        then printfn "Invalid value.Enter a value greater then 20! "
        else
            for i=0 to marbleno-1 do
                reservoir.Enqueue(i)
                reservoir1.Enqueue(i)

            let mutable temp=true            
            while (reservoir.ToArray()<>reservoir1.ToArray()) || temp do
                temp<-false
                let mutable firstelement=reservoir.Dequeue()
                if tray_1.Count<4
                then
                    min_1<-min_1+1
                    tray_1.Push(firstelement)                     
                else 
                if tray_5.Count<2
                    then            
                        tray_5.Push(firstelement)
                        min_1<-0
                        min_5<-min_5+1              
                        let mutable tray_1count=0
                        while tray_1count< 4 do
                            let ele=tray_1.Pop()
                            reservoir.Enqueue(ele)
                            tray_1count<-tray_1count+1              
                    else
                            if tray_15.Count<3
                            then
                                tray_15.Push(firstelement)
                                min_15<-min_15+1
                                min_5<-0
                                min_1<-0
                                let mutable tray_1count=0
                                while tray_1count< 4 do
                                    let ele=tray_1.Pop()
                                    reservoir.Enqueue(ele)
                                    tray_1count<-tray_1count+1
                                let mutable tray_5count=0
                                while tray_5count< 2  do
                                    let ele=tray_5.Pop()
                                    reservoir.Enqueue(ele)
                                    tray_5count<-tray_5count+1
                            else
                                if tray_60.Count<11
                                then                         
                                    tray_60.Push(firstelement)
                                    min_60<-min_60+1
                                    min_15<-0
                                    min_5<-0
                                    min_1<-0
                                    let mutable tray_1count=0
                                    while tray_1count< 4 do
                                        let ele=tray_1.Pop()
                                        reservoir.Enqueue(ele)
                                        tray_1count<-tray_1count+1
                                    let mutable tray_5count=0
                                    while tray_5count< 2  do
                                        let ele=tray_5.Pop()
                                        reservoir.Enqueue(ele)
                                        tray_5count<-tray_5count+1
                                    let mutable tray_15count=0
                                    while tray_15count< 3  do
                                        let ele=tray_15.Pop()
                                        reservoir.Enqueue(ele)
                                        tray_15count<-tray_15count+1                      
                                    else
                                   //Cycle complete
                                        cycle_12<-cycle_12+1
                                        let mutable tray_1count=0
                                        while tray_1count< 4 do
                                            let ele=tray_1.Pop()
                                            reservoir.Enqueue(ele)
                                            tray_1count<-tray_1count+1
                                        let mutable tray_5count=0
                                        while tray_5count< 2  do
                                            let ele=tray_5.Pop()
                                            reservoir.Enqueue(ele)
                                            tray_5count<-tray_5count+1
                                        let mutable tray_15count=0
                                        while tray_15count< 3  do
                                            let ele=tray_15.Pop()
                                            reservoir.Enqueue(ele)
                                            tray_15count<-tray_15count+1
                                        let mutable tray_60count=0
                                        while tray_60count< 11  do
                                            let ele=tray_60.Pop()
                                            reservoir.Enqueue(ele)
                                            tray_60count<-tray_60count+1                        
                                        reservoir.Enqueue(firstelement)
            printfn "\nNumber of twelve hours cycle are: %d\n"cycle_12 
                      
          with
        | :? System.Exception as ex -> printfn "Invalid input! %s \n" (ex.Message);
let funchoice () =    
        printfn "Enter choice";
        printfn "1. Start marble clock"
        printfn "2. Exit";
        let choice= int32(System.Console.ReadLine())
        if choice = 1
        then
            marbleclock()
        else 
        printfn "End of the application "
        System.Environment.Exit(1);
while true do
    funchoice()
        

