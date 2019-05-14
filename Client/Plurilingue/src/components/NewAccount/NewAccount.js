//import liraries
import React, { Component } from 'react';
import { View, Text, StyleSheet, TouchableOpacity, Dimensions, Image, TextInput} from 'react-native';
import Icon from 'react-native-vector-icons/MaterialIcons';
import defaultAvatar from './../../../images/default-user.jpg';
import axios from 'axios';

const {width: WIDTH} = Dimensions.get('window')
const {height: HEIGHT} = Dimensions.get('window')
// create a component
class NewAccount extends Component {

    constructor(props){
        super(props);
        this.state = {
            email:'',
            password:'',
            country:'',
            showPass: true,
            press: false
        }
    }

    static navigationOptions = {
        header: null
    }

    showPass = () => {
        if(this.state.press == false){
            this.setState({showPass: false, press: true})
        }else{
            this.setState({showPass: true, press: false})
        }
    }

    submit(){
        let data = {}
        data.email = this.state.email
        data.password = this.state.password
        data.country = this.state.country

        axios({
            url: 'http://10.0.2.2:5000/v1/Auth/register',
            method: 'post',
            data: {
                email: this.state.email,
                password: this.state.password,
                country: this.state.country
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
            // console.warn(this.props.navigation.state.routeName);
            this.props.navigation.navigate('Erro', {errorMessage: error.response.data, screenPath: this.props.navigation.state.routeName});
          });
      
      }

    render() {
        return (
            <View style={styles.container}>
                <TouchableOpacity style={styles.backButton} onPress={() => this.props.navigation.navigate('Login')}>
                    <Icon name='keyboard-arrow-left' size={50} color={'rgba(255,255,255,0.7)'}/>
                </TouchableOpacity>

                <View style={styles.avatarContainer}>
                    <Image style={styles.userAvartar} source={defaultAvatar}/>
                </View>

                <View style={styles.inputContainer}>
                    {/* <Icon name='person-outline' size={28} color={'rgba(255,255,255,0.7)'} style={styles.iconInput}/> */}
                    <TextInput 
                        style={styles.input}
                        placeholder={'E-mail'}
                        placeholderTextColor={'rgba(255,255,255,0.7)'}
                        underlineColorAndroid='transparent'
                        onChangeText={value=> this.setState({ email: value})}
                        value={this.state.email}
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
                        onChangeText={value=> this.setState({ password: value})}
                        value={this.state.password}
                    />

                    <TouchableOpacity style={styles.btnEye} onPress={this.showPass.bind(this)}>
                        <Icon name={this.state.press == false ? 'visibility-off' : 'visibility'} size={26} color={'rgba(255,255,255,0.7)'}/>
                    </TouchableOpacity>
                </View>

                <View style={styles.inputContainer}>
                    {/* <Icon name='person-outline' size={28} color={'rgba(255,255,255,0.7)'} style={styles.iconInput}/> */}
                    <TextInput 
                        style={styles.input}
                        placeholder={'Country'}
                        placeholderTextColor={'rgba(255,255,255,0.7)'}
                        underlineColorAndroid='transparent'
                        onChangeText={value=> this.setState({ country: value})}
                        value={this.state.country}
                    />
                </View>

                <TouchableOpacity style={styles.btnCreate} onPress={() => this.submit()}>
                    <Text style={styles.text}>Sign up</Text>
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
    },
    backButton:{
        bottom: 175,
        right: 175,
        borderRadius: 100,
        backgroundColor: '#432577'
    },
    avatarContainer: {
        alignItems: 'center',
        borderRadius: 100,
        borderWidth: 1,
        position: 'absolute',
        bottom: 450
    },
    userAvartar:{
        width: 150,
        height: 150,
        borderRadius: 100,
    },
    inputContainer:{
        marginTop: 10
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
    btnCreate: {
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
    iconInput:{
        position: 'absolute',
        left: 40,
        top: 10
    },
    btnEye: {
        position: 'absolute',
        right: 40,
        top: 10
    },
});

//make this component available to the app
export default NewAccount;
