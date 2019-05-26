import React, { Component } from 'react';
import { View, Text, StyleSheet, Dimensions, TouchableOpacity } from 'react-native';
import { Container, Header, Right, Button } from 'native-base';
import IconMD from 'react-native-vector-icons/MaterialIcons';
import Icon from 'react-native-vector-icons/Ionicons';


const {width: WIDTH} = Dimensions.get('window')
const {height: HEIGHT} = Dimensions.get('window')
// create a component
class Home extends Component {

    static navigationOptions = {
        header: null
    }
    render() {
        const { navigation } = this.props;
        const userId = navigation.getParam('userId');
        const user = navigation.getParam('user');
        const userPoints = navigation.getParam('userPoints');
        return (
                <Container>
                    <Header style={{backgroundColor: "#d63031"}}>
                        <Right>
                            <Button style={{backgroundColor: "#d63031"}} onPress={() => this.props.navigation.navigate('Login')}>
                            <Icon name='md-exit' size={35} style={{color: "#fff"}}/>
                            </Button>
                        </Right>
                    </Header>
                <View style={styles.header}>
                    <Text style={styles.title}>Welcome: {user}</Text>
                    <Text style={styles.title}>Current Points</Text>
                    <Text>
                        <IconMD name="stars" color={'#f1c40f'} size={30}/>
                        <Text style={styles.points}>{userPoints}</Text>
                    </Text>
                </View>
                <View style={{flexDirection:"row", top: 100, justifyContent: 'center' }}>
                    <TouchableOpacity onPress={() => this.props.navigation.navigate('Forum',{
                        userId: userId
                    })}>
                        <View style={styles.actionButtons}>
                            <IconMD name="forum" size={100} style={{color: "#fff"}}/>
                            <Text style={styles.actionButtonsTxt}>Forum</Text>
                        </View>
                    </TouchableOpacity>
                    <TouchableOpacity>
                        <View style={styles.actionButtons}>
                            <IconMD name="group" size={100} style={{color: "#fff"}}/>
                            <Text style={styles.actionButtonsTxt}>Rank</Text>
                        </View>
                    </TouchableOpacity>
                </View>
                </Container>
        );
    }
}

// define your styles
const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: '#ffffff',
    },
    header: {
        backgroundColor: '#d63031',
        width: WIDTH,
        height: 250,
        justifyContent: 'center',
        alignItems: 'center'
    },
    title: {
        fontSize: 21,
        fontWeight: 'bold',
        color: 'white',
        marginBottom: 10
    },
    points: {
        fontSize: 25,
        color: 'white'
    },
    actionButtons:{
        width: 130,
        height: 130,
        backgroundColor:"#d63031",
        justifyContent: 'center',
        alignItems: 'center',
        margin: 30,
        borderRadius:80,
        bottom: 50,
    },
    actionButtonsTxt:{
        fontSize: 21,
        fontWeight: 'bold',
        position: 'absolute',
        top: 130
    }
});

//make this component available to the app
export default Home;
