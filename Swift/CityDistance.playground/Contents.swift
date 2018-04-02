//: Playground - noun: a place where people can play

import PlaygroundSupport    // Prevents xcode from freezing on e.g. "Running PlaygroundName"
import UIKit
/*
 QUESTION: calculate the distance of the nearest city from the user, starting at 0
 
 INPUT: tip,955; crk,123; dub,548;"

 OUTPUT: 123, 425, 430
 
 */

let userIn:String = "tip,955; crk,123; dub,548;";

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


extension String {
    
    func split(regex pattern: String) -> [String] {
        
        guard let re = try? NSRegularExpression(pattern: pattern, options: [])
            else { return [] }
        
        let nsString = self as NSString // needed for range compatibility
        let stop = "<SomeStringThatYouDoNotExpectToOccurInSelf>"
        let modifiedString = re.stringByReplacingMatches(
            in: self,
            options: [],
            range: NSRange(location: 0, length: nsString.length),
            withTemplate: stop)
        return modifiedString.components(separatedBy: stop)
    }
}


func distanceOfCities(input:String){
    
    let citiesList = matches(for: "#[a-z0-9]+", in: input)
    
//   let citiesList =  input.split(regex: ",|;|[ \\s]")    // ["hello", "world"]
    
//    let citiesList = input.split(regex: "[a-z0-9]+")
    
    for item in 0..<citiesList.count {
        print(citiesList[item])
    }
    
//    return "Hello World"
    
}

distanceOfCities(input: userIn)


