//import liraries
import React, { Component } from 'react';
import { StyleSheet, Dimensions } from 'react-native';
import { Container, Content, List, ListItem, Text, Left, Body, Right, Textarea, Button } from 'native-base';
import Icon from 'react-native-vector-icons/Ionicons';

// create a component
const {width: WIDTH} = Dimensions.get('window')
const {height: HEIGHT} = Dimensions.get('window')
class QuestionForm extends Component {
    constructor(){
        super();
    }

    render() {
        const { navigation } = this.props;
        const Question = navigation.getParam('item');
        return (
            <Container>
            <Content>
                <List>
                    <ListItem avatar style={styles.questionContent}>
                        <Body>
                            <Text style={styles.title}>{Question.title}</Text>
                            <Text note numberOfLines={1} style={styles.textContent}>{Question.textContent}</Text>
                        </Body>
                    </ListItem>
                    <ListItem avatar style={styles.answerContent}>
                        <Left style={{margin: 20}}>
                            <Icon name='ios-checkbox-outline' size={50}></Icon>
                        </Left>
                        <Body>
                            <Text>woeifiose fwuiehui fwuieh fiuwehfuihiu wehufh
                                weofui hweiufhwuiehfiu wehuif hweiufhwuiehfiuwe fuhweifuh
                                weuif hwiuefh uiwehiu fhweiu hfiweh fi whe ifhwei fhiwefu
                                wefui hwuie hfiuweh uifhwei uhfiwe hfiuweh woefhuiowe hfiuwehweoi fhwoieh
                                w eiofoiwe iofjweio fjiowjeiofjio wejfo iwjeo 
                            </Text>
                        </Body>
                    </ListItem>
                </List>
                <Textarea rowSpan={5} bordered placeholder='Your answer goes here' style={{marginTop: 30, width: WIDTH - 60, left: 30}}/>
                <Button block danger style={{width: WIDTH - 100, marginTop: 40, justifyContent: 'center', left: 50}}>
                        <Text style={{fontSize: 18, color: 'white', fontWeight: 'bold'}}>Submit</Text>
                </Button>
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
    title:{
        marginTop: 10,
        marginBottom: 10,
        fontSize: 24,
        fontWeight: 'bold'
    },
    questionContent:{
        backgroundColor: '#dedede',
        width: WIDTH - 40,
        borderRadius: 10,       
    },
    textContent:{
        fontSize: 18,
    },
    answerContent:{
        backgroundColor: '#f1efef',
        width: WIDTH - 40,
        borderRadius: 10,  
    }
});

//make this component available to the app
export default QuestionForm;
