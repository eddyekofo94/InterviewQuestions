//: Playground - noun: a place where people can play
import PlaygroundSupport    // Prevents xcode from freezing on e.g. "Running PlaygroundName"
import UIKit


/*
 QUESTION: find the distance between two points of graph: points (23, 8) (-2, 9)
 the input is given in a string format,
 
 INPUT: (23, 8) (-2, 9) (the input is given in a string format)
 
 OUTPUT: 18 (print in integer format)
 */

let input = "(23, 8) (-2, 9)"

//Points with x & y axis co-ordinates
struct Point{
  var  x:Int?, y:Int?
}

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

func distance(input: String) -> Int {
    
    // Parse the data and get x & y axis
    let tempPoints = matches(for: "-?[0-9]\\d*(\\.\\d+)?", in: input)
    let points = tempPoints.map { Int($0)!} //Change all the data into the array into ints

    let point1 = Point(x: points[0], y:points[2]), point2 =  Point(x: points[1], y:points[3])
    
    // formula
    let result = sqrt(pow(Double(point2.x! - point1.x!),2) + pow(Double(point2.y! - point1.y!),2))
    //return the output
    return Int(result)  // casts to int (floors everything)
}

var res = distance(input: input)

print("Distance between the two points is: \(res)")


