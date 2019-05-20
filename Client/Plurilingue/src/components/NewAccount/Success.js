//import liraries
import React, { Component } from 'react';
import { View, Text, StyleSheet,TouchableOpacity } from 'react-native';
import LottieView from 'lottie-react-native';

// create a component
class Success extends Component {

    static navigationOptions = {
        header: null
    }
    render() {
        return (
            <View style={styles.container}>
                <LottieView
                style={styles.animation}
                loop={false}
                duration={2000} 
                source={require('../../../android/animations/1818-success-animation.json')} autoPlay />
                <Text style={styles.text}>Thanks for joining Plurilíngue.</Text>
                <Text style={styles.text}>We hope you enjoy our services.</Text>
                <TouchableOpacity style={styles.btnSignIn} onPress={() => this.props.navigation.navigate('Login')}>
                    <Text style={styles.txtBtnSignIn}>Sign In</Text>
                </TouchableOpacity>
            </View>
        );
    }
}

// define your styles
const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: '#d63031',
    },
    text: {
        top: 55,
        color: 'rgba(255, 255, 255, 0.7)',
        fontSize: 25,
        textAlign: 'center',
        fontWeight: 'bold'
    },
    animation:{
        bottom: 110
    },
    btnSignIn: {
        height: 50,
        borderRadius: 45,
        backgroundColor: '#432577',
        justifyContent: 'center',
        top: 80,
        padding: 20
    },
    txtBtnSignIn: {
        color: 'rgba(255, 255, 255, 0.7)',
        fontSize: 20,
        textAlign: 'center',
        fontWeight: 'bold'
    }
});

//make this component available to the app
export default Success;
