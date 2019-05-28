//import liraries
import React, { Component } from 'react';
import { StyleSheet, FlatList } from 'react-native';
import { Container, Content, List, ListItem, Text, Left, Body, Right } from 'native-base';
import IconMD from 'react-native-vector-icons/MaterialIcons';

// create a component
class Rank extends Component {

    constructor(){
        super();
        this.state={
            users: []
        }
    }

    componentWillMount(){
        fetch('https://plurilingueapplication20190526092258.azurewebsites.net/v1/Auth/rank')
        .then((response) => response.json())
        .then((responseJson) => {
          this.setState({
            users: responseJson
          })
        })
    }

    render() {
        return (
        <Container>
            <Content>
            <List>
                <FlatList
                data={this.state.users}
                renderItem={({item}) => (
                    <ListItem thumbnail>
                    <Left>
                        
                    </Left>
                    <Body>
                        <Text>{item.userName}</Text>
                    </Body>
                    <Right>
                        <IconMD name="stars" color={'#f1c40f'} size={30}/>
                        <Text>{item.userPoints}</Text>
                    </Right>
                    </ListItem>
                )}
                keyExtractor={(item, index) => index.toString()}
                />
            </List>
            </Content>
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
        backgroundColor: '#fff',
    },
});

//make this component available to the app
export default Rank;
