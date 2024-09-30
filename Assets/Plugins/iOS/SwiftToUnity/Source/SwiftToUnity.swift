import Foundation
import CoreLocation // Import CoreLocation to access location services
import WeatherKit // Import WeatherKit to access weather data

@objcMembers public class SwiftToUnity: NSObject {
    @objc public static let shared = SwiftToUnity()
    
    
    /// Requests the current weather data once the location is available.
    @objc public func swiftGetWeather() {
        UnitySendMessage("Canvas", "OnMessageReceived", "WeatherData")
        
    }
}
