//import liraries
import React, { Component } from 'react';
import { View, Text, StyleSheet,TouchableOpacity } from 'react-native';
import LottieView from 'lottie-react-native';

// create a component
class Erro extends Component {

    redirectScreen(screenPath){
        if(screenPath == 'NewAccount')
            this.props.navigation.navigate('NewAccount')
        else
            this.props.navigation.navigate('Login')
    }

    static navigationOptions = {
        header: null
    }
    render() {
        const { navigation } = this.props;
        const screenPath = navigation.getParam('screenPath');
        const errorMessage = navigation.getParam('errorMessage');
        return (
            <View style={styles.container}>
                <LottieView
                style={styles.animation}
                loop={false}
                duration={2000} 
                source={require('../../../android/animations/4970-unapproved-cross.json')} autoPlay />
                <Text style={styles.text}>Ops... Something bad happen.</Text>
                <Text style={styles.text}>Erro: {errorMessage}</Text>
                <Text style={styles.text}>Try again, please.</Text>
                <TouchableOpacity style={styles.btnSignIn} onPress={() => this.redirectScreen(screenPath)}>
                    <Text style={styles.txtBtnSignIn}>Back</Text>
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
export default Erro;
