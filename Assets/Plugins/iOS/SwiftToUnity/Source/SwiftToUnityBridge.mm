#import <UnityFramework/UnityFramework-Swift.h>
#import "UnityInterface.h"

extern "C"
{

    void cGetWeather()
    {
        [[SwiftToUnity shared] swiftGetWeather];
    }
}
