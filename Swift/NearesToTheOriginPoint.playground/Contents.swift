//: Playground - noun: a place where people can play

import UIKit

//var str = "Hello, playground"
/*
 QUESTION: Given an array of two points and the origi is (0,0), find which 2 closest points nearest to the origin
 
 Input: [(-6,10),(2,4), (5,3), (9,5),(6,7)]   // the points of the graph
 
 OUT: two nearest points: (2,4), (5,3)
 
 */

let input = "(-6,10), (2,4), (5,3), (9,5), (6,7)"

struct Point{
    var x:Int = 0, y:Int = 0
}

//Parse the input
// Parses the string using regex
func matches(for regex: String, in text: String) -> [String] {
    
    do {
        let regex = try NSRegularExpression(pattern: regex)
        let tempResults = regex.matches(in: text,
                                        range: NSRange(text.startIndex..., in: text))
        return tempResults.map {
            String(text[Range($0.range, in: text)!])
        }
    } catch let error {
        print("invalid regex: \(error.localizedDescription)")
        return []
    }
}

// Array of Ints
func arrayOfPoints(input: String)-> [Int]{
    let tempArray = matches(for: "-?[0-9]\\d*(\\.\\d+)?", in: input)    // extract all the points of the input
    let arrayOfPoints = tempArray.map { Int($0)!} // Converts into array of ints
    
    return arrayOfPoints
}

//Array imto dictionaty
func dictionaryOfPoints(pointsArray:[Int]) { // -> Dictionary<String, Point>
    
//        for i in stride(from: 0, to: pointsArray.count, by: 2){
//
//            print(pointsArray[i])
//        }
    
    var point = Point()
    var pointsDict = [String: Point]()
    for (i, value) in pointsArray.enumerated() {
        
//        print(pointsArray[(i)])
      
        point.x = pointsArray[i]
        point.y = pointsArray[(i)];

        pointsDict["Point\(i)"] = point
        
    }
    print("This is the console output: \(pointsDict as AnyObject)")

//  dump(pointsDict)
//    return pointsDict
    
}

func nearestToOrigin(input:String){
    //    print(input)
    let points = arrayOfPoints(input: input)
    
    
    var dicOfPoints = dictionaryOfPoints(pointsArray:points)
    
    
}

nearestToOrigin(input: input)










