import React, { Component } from 'react';
import { View, Text, StyleSheet, Dimensions, TextInput, TouchableOpacity, Image } from 'react-native';
import Icon from 'react-native-vector-icons/MaterialIcons';
import logo from './../../../images/logo.png';
import axios from 'axios';

const {width: WIDTH} = Dimensions.get('window')
const {height: HEIGHT} = Dimensions.get('window')
// create a component
class Login extends Component {
    constructor(){
        super()
        this.state ={
            email:'',
            password:'',
            showPass: true,
            press: false
        }
    }

    static navigationOptions = {
        header: null
    }

    login(){
        let data = {}
        data.email = this.state.email
        data.password = this.state.email
        axios({
            url: 'http://10.0.2.2:5000/v1/Auth/login',
            method: 'post',
            data: {
                email: this.state.email,
                password: this.state.password
            },
            headers: {
              Accept: 'application/json',
              'Content-Type': 'application/json',
            }
          })
          .then(response => {
            this.props.navigation.navigate('Success');
            // console.warn(response);
          })
          .catch(error => {
            this.props.navigation.navigate('Erro', {errorMessage: error.response.data});
            // console.warn(error.response.data);
          });
    }

    showPass = () => {
        if(this.state.press == false){
            this.setState({showPass: false, press: true})
        }else{
            this.setState({showPass: true, press: false})
        }
    }
    render() {
        return (
            <View style={styles.container}>
                <View style={styles.logoContainer}>
                    <Image source={logo} style={styles.logo}></Image>
                    <Text style={styles.logoText}>Plurilíngue</Text>
                </View>

                <View style={styles.inputContainer}>
                    <Icon name='person-outline' size={28} color={'rgba(255,255,255,0.7)'} style={styles.iconInput}/>
                    <TextInput 
                        style={styles.input}
                        placeholder={'Username'}
                        placeholderTextColor={'rgba(255,255,255,0.7)'}
                        underlineColorAndroid='transparent'
                    />
                </View>

                <View style={styles.inputContainer}>
                    <Icon name='lock-outline' size={28} color={'rgba(255,255,255,0.7)'} style={styles.iconInput}/>
                    <TextInput 
                        style={styles.input}
                        placeholder={'Password'}
                        secureTextEntry={this.state.showPass}
                        placeholderTextColor={'rgba(255,255,255,0.7)'}
                        underlineColorAndroid='transparent'
                    />
                    <TouchableOpacity style={styles.btnEye} onPress={this.showPass.bind(this)}>
                        <Icon name={this.state.press == false ? 'visibility-off' : 'visibility'} size={26} color={'rgba(255,255,255,0.7)'}/>
                    </TouchableOpacity>
                </View>

                <TouchableOpacity style={styles.btnLogin} onPress={() => this.login()}>
                    <Text style={styles.text}>Login</Text>
                </TouchableOpacity>
                
                <View style={styles.otherButtons}>
                    <TouchableOpacity style={styles.otherButtonsBtn} onPress={() => this.props.navigation.navigate('NewAccount')}>
                        <Text style={styles.text}>Don't have an account?</Text>
                    </TouchableOpacity>

                    <TouchableOpacity style={styles.otherButtonsBtn}>
                        <Text style={styles.text}>Forget password?</Text>
                    </TouchableOpacity>
                </View>

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
    logoContainer: {
        alignItems: 'center'
    },
    logo: {
        width: 150,
        height: 150
    },
    logoText: {
        color: 'white',
        fontSize: 25,
        fontWeight: 'bold',
        marginTop: 10,
        marginBottom: 30
    },
    input: {
        width: WIDTH - 100,
        height: 50,
        borderRadius: 45,
        fontSize: 20,
        paddingLeft: 55,
        backgroundColor: 'rgba(0,0,0,0.35)',
        color: 'rgba(255, 255, 255, 0.7)',
        marginHorizontal: 25
    },
    iconInput:{
        position: 'absolute',
        left: 40,
        top: 10
    },
    inputContainer:{
        marginTop: 10
    },
    btnEye: {
        position: 'absolute',
        right: 40,
        top: 10
    },
    btnLogin: {
        width: WIDTH - 100,
        height: 50,
        borderRadius: 45,
        backgroundColor: '#432577',
        justifyContent: 'center',
        marginTop: 20
    },
    text: {
        color: 'rgba(255, 255, 255, 0.7)',
        fontSize: 20,
        textAlign: 'center'
    },
    otherButtons:{
        height: 16,
        marginTop: 70
    },
    otherButtonsBtn: {
        width: WIDTH,
        padding: 10,
        backgroundColor:'#6c38c5',
        borderWidth: 0.5
    }
});

//make this component available to the app
export default Login;
