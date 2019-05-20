//import liraries
import React, { Component } from 'react';
import { View, Text, StyleSheet, Dimensions, TouchableOpacity } from 'react-native';
import { Container, Header, Right, Button, Icon } from 'native-base';
import IconMD from 'react-native-vector-icons/MaterialIcons';

const {width: WIDTH} = Dimensions.get('window')
const {height: HEIGHT} = Dimensions.get('window')
// create a component
class Home extends Component {

    static navigationOptions = {
        header: null
    }
    render() {
        return (
            <View>
                <Container>
                    <Header style={{backgroundColor: "#d63031"}}>
                        <Right>
                            <Button style={{backgroundColor: "#d63031"}}>
                            <Icon name='menu' />
                            </Button>
                        </Right>
                    </Header>
                </Container>
                <View style={styles.header}>
                    <Text style={styles.title}>Current Points</Text>
                    <Text>
                        <IconMD name="stars" color={'#f1c40f'} size={30}/>
                        <Text style={styles.points}>6516</Text>
                    </Text>
                </View>
                <View style={{flexDirection:"row", top: 150, justifyContent: 'center' }}>
                    <TouchableOpacity>
                        <View style={styles.actionButtons}>
                            <IconMD name="forum" size={100} style={{borderWidth: 1.5, borderRadius:30, color: "#d63031"}}/>
                            <Text style={styles.actionButtonsTxt}>Forúm</Text>
                        </View>
                    </TouchableOpacity>
                    <TouchableOpacity onPress={() => this.props.navigation.navigate('Forum')}>
                        <View style={styles.actionButtons}>
                            <IconMD name="group" size={100} style={{borderWidth: 1.5, borderRadius:30, color: "#d63031"}}/>
                            <Text style={styles.actionButtonsTxt}>Rank</Text>
                        </View>
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
        backgroundColor: '#ffffff',
    },
    header: {
        backgroundColor: '#d63031',
        width: WIDTH,
        top: 55,
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
        margin: 10,
        width: 105,
        
        justifyContent: 'center',
        alignItems: 'center',
        
        margin: 15
    },
    actionButtonsTxt:{
        fontSize: 21,
        fontWeight: 'bold',
    }
});

//make this component available to the app
export default Home;
